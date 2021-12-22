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
using System.Configuration;

namespace Project.UserControls
{
    public partial class Prijemnica : UserControl
    {
        OracleConnection con;
        public Prijemnica(OracleConnection con)
        {
            this.con = con;
            InitializeComponent();
            string query1 = "SELECT SIFRAMAGACINA, NAZIV FROM MAGACIN";
            string query2 = "SELECT * FROM RADNIK";
            string query3 = "SELECT * FROM DOBAVLJAC";
            try
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = query1;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbMagacin.DataSource = dt;
                cbMagacin.ValueMember = "siframagacina";
                cbMagacin.DisplayMember = "naziv";

                OracleCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = query2;
                OracleDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                cbRadnikPrimio.DataSource = dt1;
                cbRadnikPrimio.ValueMember = "sifraradnika";
                cbRadnikPrimio.DisplayMember = "imeprezime";

                cbOdgLice.DataSource = dt1;
                cbOdgLice.ValueMember = "sifraradnika";
                cbOdgLice.DisplayMember = "imeprezime";

                OracleCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = query3;
                OracleDataReader dr2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);
                cbDob.DataSource = dt2;
                cbDob.ValueMember = "sifradobavljaca";
                cbDob.DisplayMember = "naziv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM PRIJEMNICA ORDER BY BROJPRIJEMNICE";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvStart.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void Prijemnica_Load(object sender, EventArgs e)
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
                    cmd.Parameters.Add("BROJPRIJEMNICE", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrPrijemnice.Text);
                    cmd.Parameters.Add("DATUM", OracleDbType.Varchar2, 50).Value = dtpDatum.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("NAPOMENA", OracleDbType.Varchar2, 50).Value = txtNapomena.Text;
                    cmd.Parameters.Add("SIFRARADNIKAPRIMIO", OracleDbType.Int32, 10).Value = cbRadnikPrimio.SelectedValue;
                    cmd.Parameters.Add("SIFRARADNIKAODGLICE", OracleDbType.Int32, 10).Value = cbOdgLice.SelectedValue;
                    cmd.Parameters.Add("SIFRAMAGACINA", OracleDbType.Int32, 10).Value = cbMagacin.SelectedValue;
                    cmd.Parameters.Add("SIFRADOBAVLJACA", OracleDbType.Int32, 10).Value = cbDob.SelectedValue;
                    break;
                case 1:
                    msg = "Row updated Successfuly!";
                    cmd.Parameters.Add("BROJPRIJEMNICE", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrPrijemnice.Text);
                    cmd.Parameters.Add("DATUM", OracleDbType.Varchar2, 50).Value = dtpDatum.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("NAPOMENA", OracleDbType.Varchar2, 50).Value = txtNapomena.Text;
                    cmd.Parameters.Add("SIFRARADNIKAPRIMIO", OracleDbType.Int32, 10).Value = cbRadnikPrimio.SelectedValue;
                    cmd.Parameters.Add("SIFRARADNIKAODGLICE", OracleDbType.Int32, 10).Value = cbOdgLice.SelectedValue;
                    cmd.Parameters.Add("SIFRAMAGACINA", OracleDbType.Int32, 10).Value = cbMagacin.SelectedValue;
                    cmd.Parameters.Add("SIFRADOBAVLJACA", OracleDbType.Int32, 10).Value = cbDob.SelectedValue;
                    break;
                case 2:
                    msg = "Row deleted Successfuly!";
                    cmd.Parameters.Add("BROJPRIJEMNICE", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrPrijemnice.Text);
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
            string sql = "INSERT INTO PRIJEMNICA (BROJPRIJEMNICE, DATUM, NAPOMENA, NAZIVMAGACINA, SIFRARADNIKAPRIMIO, SIFRARADNIKAODGLICE, SIFRAMAGACINA, SIFRADOBAVLJACA, UKUPNO)" +
                " VALUES (:BROJPRIJEMNICE, TO_DATE(:DATUM,'yyyy/mm/dd'), :NAPOMENA, NULL, :SIFRARADNIKA, :SIFRARADNIKAODGLICE, :SIFRAMAGACINA, :SIFRADOBAVLJACA, 0)";
            this.AUD(sql, 0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM PRIJEMNICA " +
                "WHERE BROJPRIJEMNICE = :BROJPRIJEMNICE";
            this.AUD(sql, 2);
            this.ResetAll();
        }

        public void ResetAll() {
            txtBrPrijemnice.Text = "";
            txtNapomena.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ResetAll();
        }

        private void dgvStart_DoubleClick(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)dgvStart.SelectedRows[0].DataBoundItem;
            if (dr != null)
            {
                txtBrPrijemnice.Text = dr["BROJPRIJEMNICE"].ToString();
                dtpDatum.Value = DateTime.Parse(dr["DATUM"].ToString());
                txtNapomena.Text = dr["NAPOMENA"].ToString();
                cbMagacin.Text = dr["NAZIVMAGACINA"].ToString();
                
            }
        }
    }
}
