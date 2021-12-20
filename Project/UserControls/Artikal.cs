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
    public partial class Artikal : UserControl
    {
        OracleConnection con;
        public Artikal(OracleConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT a.Sifra AS SifraArtikla, a.Naziv AS NazivArtikla, a.Tezina.get_tezina()" +
                " AS TezinaArtikla, a.OpisProizvoda.get_primena()" +
                " AS PrimenaArtikla, a.OpisProizvoda.get_rok() AS" +
                " RokTrajanja, a.Cena AS CenaKostanja, a.AKTUELNACENA as AKTUELNACENA FROM Artikal a";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvStart3.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void Artikal_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }
    }
}
