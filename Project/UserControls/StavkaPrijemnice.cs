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
    public partial class StavkaPrijemnice : UserControl
    {
        OracleConnection con;
        public StavkaPrijemnice(Oracle.ManagedDataAccess.Client.OracleConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM STAVKAPRIJEMNICE ORDER BY BROJPRIJEMNICE";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvStart1.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void StavkaPrijemnice_Load(object sender, EventArgs e)
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
                    cmd.Parameters.Add("RB", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrojPrijemnice.Text);
                    cmd.Parameters.Add("BROJPRIJEMNICE", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrojPrijemnice.Text);
                    cmd.Parameters.Add("KOLICINA", OracleDbType.Double, 9).Value = Double.Parse(txtKolicina.Text);
                    break;
                case 1:
                    msg = "Row updated Successfuly!";
                    cmd.Parameters.Add("RB", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrojPrijemnice.Text);
                    cmd.Parameters.Add("BROJPRIJEMNICE", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrojPrijemnice.Text);
                    cmd.Parameters.Add("KOLICINA", OracleDbType.Double, 9).Value = Double.Parse(txtKolicina.Text);
                    break;
                case 2:
                    msg = "Row deleted Successfuly!";
                    cmd.Parameters.Add("RB", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrojPrijemnice.Text);
                    cmd.Parameters.Add("BROJPRIJEMNICE", OracleDbType.Int32, 10).Value = Int32.Parse(txtBrojPrijemnice.Text);
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
            string sql = "INSERT INTO STAVKAPRIJEMNICE (RB, BROJPRIJEMNICE, DATUMPRIJEMNICE, KOLICINA)" +
                " VALUES (:RB, :BROJPRIJEMNICE, NULL, :KOLICINA)";
            this.AUD(sql, 0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM STAVKAPRIJEMNICE " +
                "WHERE RB = :RB AND BROJPRIJEMNICE = :BROJPRIJEMNICE";
            this.AUD(sql, 2);
            this.ResetAll();
        }

        private void ResetAll() {
            txtRbr.Text = "";
            txtBrojPrijemnice.Text = "";
            txtKolicina.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ResetAll();
        }

        private void dgvStart1_DoubleClick(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)dgvStart1.SelectedRows[0].DataBoundItem;
            if (dr != null)
            {
                txtRbr.Text = dr["RB"].ToString();
                txtBrojPrijemnice.Text = dr["BROJPRIJEMNICE"].ToString();
                txtKolicina.Text = dr["KOLICINA"].ToString();
            }
        }
    }
}
