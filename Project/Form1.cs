using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using Project.UserControls;

namespace Project
{
    public partial class Form1 : Form
    {
        OracleConnection con = null;
        
        public Form1()
        {
            this.SetConnection();
            InitializeComponent();
            
        }

        public void PanelMethod(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;

        }

      

        private void SetConnection() {
            string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            con = new OracleConnection(connectionString);
            try {
                con.Open();
            }
            catch (Exception ex) { 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                PanelMethod(new Prijemnica(con));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }

        private void stavkePrijemniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PanelMethod(new StavkaPrijemnice(con));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prijemnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PanelMethod(new Prijemnica(con));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dobavljacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PanelMethod(new Dobavljac(con));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void artikalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PanelMethod(new Artikal(con));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void magacinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PanelMethod(new Magacin(con));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PanelMethod(new Radnik(con));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PanelMethod(new Cena(con));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
