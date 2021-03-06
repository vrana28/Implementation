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
    public partial class Cena : UserControl
    {
        OracleConnection con;
        public Cena(OracleConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM CENA ORDER BY SIFRAARTIKLA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvStart6.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void Cena_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void AUD(string sql_stmt, int state)
        {

            String msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stmt;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    msg = "Row inserted Successfuly!";
                    cmd.Parameters.Add("SIFRAARTIKLA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifra.Text);
                    cmd.Parameters.Add("DATUMOD", OracleDbType.Varchar2, 50).Value = dtpDatumOd.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("CENA", OracleDbType.Double, 9).Value = Double.Parse(txtCena.Text);
                    break;
                case 1:
                    msg = "Row updated Successfuly!";
                    cmd.Parameters.Add("CENA", OracleDbType.Double, 9).Value = Double.Parse(txtCena.Text);
                    cmd.Parameters.Add("SIFRAARTIKLA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifra.Text);
                    cmd.Parameters.Add("DATUMOD", OracleDbType.Varchar2, 50).Value = dtpDatumOd.Value.ToString("yyyy-MM-dd");
                    break;
                case 2:
                    msg = "Row deleted Successfuly!";
                    cmd.Parameters.Add("SIFRAARTIKLA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifra.Text);
                    cmd.Parameters.Add("DATUMOD", OracleDbType.Varchar2, 50).Value = dtpDatumOd.Value.ToString("yyyy-MM-dd");
                    break;
            }

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    this.updateDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO CENA (SIFRAARTIKLA, DATUMOD, CENA)" +
                " VALUES (:SIFRAARTIKLA, TO_DATE(:DATUMOD,'yyyy/mm/dd'), :CENA)";
            this.AUD(sql, 0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE CENA SET " +
                "CENA =:CENA WHERE SIFRAARTIKLA =:SIFRAARTIKLA AND  DATUMOD =TO_DATE(:DATUMOD, 'yyyy/mm/dd')";
            this.AUD(sql, 1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM CENA " +
                "WHERE SIFRAARTIKLA = :SIFRAARTIKLA AND DATUMOD = TO_DATE(:DATUMOD,'yyyy/mm/dd')";
            this.AUD(sql, 2);
            this.resetAll();
        }

        public void resetAll()
        {
            txtSifra.Text = "";
            txtCena.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.resetAll();
        }

        private void dgvStart6_DoubleClick(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)dgvStart6.SelectedRows[0].DataBoundItem;
            if (dr != null)
            {
                txtSifra.Text = dr["SIFRAARTIKLA"].ToString();
                dtpDatumOd.Value = DateTime.Parse(dr["DATUMOD"].ToString());
                txtCena.Text = dr["CENA"].ToString();
            }
        }
    }
}
