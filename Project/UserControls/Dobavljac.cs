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
    public partial class Dobavljac : UserControl
    {
        OracleConnection con; 
        public Dobavljac(OracleConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DOBAVLJAC_VIEW ORDER BY SIFRADOBAVLJACA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvStart2.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void Dobavljac_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void AUD(string sql_stmt, int state, int v)
        {

            String msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stmt;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    msg = "Row inserted Successfuly!";

                    if (v == 0) {
                        cmd.Parameters.Add("SIFRADOBAVLJACA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraDobavljaca.Text);
                        cmd.Parameters.Add("NAZIV", OracleDbType.Varchar2, 50).Value = txtNaziv.Text;
                        cmd.Parameters.Add("FARMA", OracleDbType.Varchar2, 50).Value = txtNaziv.Text;
                    }

                    if (v == 1) {
                        cmd.Parameters.Add("SIFRADOB", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraDobavljaca.Text);
                        cmd.Parameters.Add("PIB", OracleDbType.Int32, 10).Value = Int32.Parse(txtPIB.Text);
                        cmd.Parameters.Add("MATICNIBROJ", OracleDbType.Int32, 10).Value = Int32.Parse(txtMaticniBroj.Text);
                        cmd.Parameters.Add("RACUN", OracleDbType.Int32, 20).Value = Int64.Parse(txtRacun.Text);
                        cmd.Parameters.Add("TELEFON", OracleDbType.Int32, 20).Value = Int64.Parse(txtTelefon.Text);
                        cmd.Parameters.Add("SEDISTE", OracleDbType.Varchar2, 20).Value = txtSediste.Text;
                    }
                    break;
                case 1:
                    msg = "Row updated Successfuly!";
                    cmd.Parameters.Add("SIFRADOBAVLJACA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraDobavljaca.Text);
                    cmd.Parameters.Add("SIFRADOB", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraDobavljaca.Text);
                    cmd.Parameters.Add("NAZIV", OracleDbType.Varchar2, 50).Value = txtNaziv.Text;
                    cmd.Parameters.Add("FARMA", OracleDbType.Varchar2, 50).Value = txtNaziv.Text;
                    cmd.Parameters.Add("PIB", OracleDbType.Int32, 10).Value = Int32.Parse(txtPIB.Text);
                    cmd.Parameters.Add("MATICNIBROJ", OracleDbType.Int32, 10).Value = Int32.Parse(txtMaticniBroj.Text);
                    cmd.Parameters.Add("RACUN", OracleDbType.Int32, 20).Value = Int32.Parse(txtRacun.Text);
                    cmd.Parameters.Add("TELEFON", OracleDbType.Int32, 20).Value = Int32.Parse(txtTelefon.Text);
                    cmd.Parameters.Add("SEDISTE", OracleDbType.Varchar2, 20).Value = txtSediste.Text;
                    break;
                case 2:
                    msg = "Row deleted Successfuly!";
                    cmd.Parameters.Add("SIFRADOBAVLJACA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifraDobavljaca.Text);
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
            string sql = "INSERT INTO DOBAVLJAC (SIFRADOBAVLJACA, NAZIV, FARMA)" +
                " VALUES (:SIFRADOBAVLJACA, :NAZIV, :FARMA)";
            string sql2 = "INSERT INTO DOBAVLJAC_DETALJI (SIFRADOB, PIB, MATICNIBROJ, RACUN, TELEFON, SEDISTE)" +
                " VALUES (:SIFRADOB, :PIB, :MATICNIBROJ, :RACUN, :TELEFON, :SEDISTE)";
            this.AUD(sql, 0, 0);
            this.AUD(sql2, 0, 1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM DOBAVLJAC " +
                "WHERE SIFRADOBAVLJACA = :SIFRADOBAVLJACA";
            string sql2 = "DELETE FROM DOBAVLJAC_DETALJI" +
                " WHERE SIFRADOB = :SIFRADOBAVLJACA";
            this.AUD(sql2, 2, 0);
            this.AUD(sql, 2, 0);
            this.ResetAll();
        }

        public void ResetAll() {
            txtSifraDobavljaca.Text = "";
            txtNaziv.Text = "";
            txtFarma.Text = "";
            txtMaticniBroj.Text = "";
            txtPIB.Text = "";
            txtRacun.Text = "";
            txtSediste.Text = "";
            txtTelefon.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ResetAll();
        }

        private void dgvStart2_DoubleClick(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)dgvStart2.SelectedRows[0].DataBoundItem;
            if (dr != null)
            {
                txtSifraDobavljaca.Text = dr["SIFRADOBAVLJACA"].ToString();
                txtNaziv.Text = dr["NAZIV"].ToString();
                txtFarma.Text = dr["FARMA"].ToString();
                txtPIB.Text = dr["PIB"].ToString();
                txtMaticniBroj.Text = dr["PIB"].ToString();
                txtRacun.Text = dr["RACUN"].ToString();
                txtTelefon.Text = dr["TELEFON"].ToString();
                txtSediste.Text = dr["SEDISTE"].ToString();
            }
        }
    }
}
