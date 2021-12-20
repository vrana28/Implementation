﻿using System;
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

        
    }
}
