using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Project.UserControls
{
    public partial class Radnik : UserControl
    {
        OracleConnection con;
        public Radnik(OracleConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM RADNIK ORDER BY SIFRARADNIKA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvStart5.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void Radnik_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void AUD(string sql_stmt, int state) {

            String msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stmt;
            cmd.CommandType = CommandType.Text;

            switch (state) {
                case 0:
                    msg = "Row inserted Successfuly!";
                    cmd.Parameters.Add("SIFRARADNIKA", OracleDbType.Int32,10).Value = Int32.Parse(txtSifraRadnika.Text);
                    cmd.Parameters.Add("IMEPREZIME", OracleDbType.Varchar2, 50).Value = txtImePrezime.Text;
                    break;
                case 1:
                    msg = "Row updated Successfuly!";
                    cmd.Parameters.Add("IMEPREZIME", OracleDbType.Varchar2, 50).Value = txtImePrezime.Text;
                    cmd.Parameters.Add("SIFRARADNIKA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraRadnika.Text);
                    break;
                case 2:
                    msg = "Row deleted Successfuly!";
                    cmd.Parameters.Add("SIFRARADNIKA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraRadnika.Text);
                    break;
            }

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0) {
                    MessageBox.Show(msg);
                    this.updateDataGrid();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE RADNIK SET IMEPREZIME =:IMEPREZIME WHERE SIFRARADNIKA = :SIFRARADNIKA";
            this.AUD(sql, 1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM RADNIK " +
                "WHERE SIFRARADNIKA = :SIFRARADNIKA";
            this.AUD(sql, 2);
            this.resetAll();
        }

        public void resetAll()
        {
            txtSifraRadnika.Text = "";
            txtImePrezime.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO RADNIK (SIFRARADNIKA, IMEPREZIME)" +
                " VALUES (:SIFRARADNIKA, :IMEPREZIME)";
            this.AUD(sql, 0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.resetAll();

        }

        private void dgvStart5_DoubleClick(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)dgvStart5.SelectedRows[0].DataBoundItem;
            if (dr != null)
            {
                txtSifraRadnika.Text = dr["SIFRARADNIKA"].ToString();
                txtImePrezime.Text = dr["IMEPREZIME"].ToString();

            }
        }
    }
}
