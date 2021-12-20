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
    }
}
