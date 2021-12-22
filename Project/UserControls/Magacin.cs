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
    public partial class Magacin : UserControl
    {
        OracleConnection con;
        public Magacin(OracleConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM MAGACIN ORDER BY SIFRAMAGACINA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvStart4.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void Magacin_Load(object sender, EventArgs e)
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
                    cmd.Parameters.Add("SIFRAMAGACINA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraMagacina.Text);
                    cmd.Parameters.Add("NAZIV", OracleDbType.Varchar2, 50).Value = txtNaziv.Text;
                    break;
                case 1:
                    msg = "Row updated Successfuly!";
                    cmd.Parameters.Add("NAZIV", OracleDbType.Varchar2, 50).Value = txtNaziv.Text;
                    cmd.Parameters.Add("SIFRAMAGACINA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraMagacina.Text);
                    break;
                case 2:
                    msg = "Row deleted Successfuly!";
                    cmd.Parameters.Add("SIFRAMAGACINA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraMagacina.Text);
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
            string sql = "INSERT INTO MAGACIN (SIFRAMAGACINA, NAZIV)" +
                " VALUES (:SIFRAMAGACINA, :NAZIV)";
            this.AUD(sql, 0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE MAGACIN SET " +
                "NAZIV = :NAZIV WHERE SIFRAMAGACINA = :SIFRAMAGACINA";
            this.AUD(sql, 1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM MAGACIN " +
                "WHERE SIFRAMAGACINA = :SIFRAMAGACINA";
            this.AUD(sql, 2);
            this.resetAll();
        }

        public void resetAll() {
            txtSifraMagacina.Text = "";
            txtNaziv.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.resetAll();
        }

        private void dgvStart4_DoubleClick(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)dgvStart4.SelectedRows[0].DataBoundItem;
            if (dr != null)
            {
                txtSifraMagacina.Text = dr["SIFRAMAGACINA"].ToString();
                txtNaziv.Text = dr["NAZIV"].ToString();
                
            }
        }
    }
}
