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
                    cmd.Parameters.Add("SIFRA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifra.Text);
                    cmd.Parameters.Add("NAZIV", OracleDbType.Varchar2, 50).Value = txtNaziv.Text;
                    cmd.Parameters.Add("TEZINA", OracleDbType.Double, 9).Value = Double.Parse(txtTezina.Text);
                    cmd.Parameters.Add("PRIMENA", OracleDbType.Varchar2, 50).Value = txtPrimena.Text;
                    cmd.Parameters.Add("ROK", OracleDbType.Int32, 10).Value = Int32.Parse(numRok.Text);
                    cmd.Parameters.Add("CENA", OracleDbType.Double, 9).Value = Double.Parse(txtCenaKostanja.Text);
                    break;
                case 1:
                    msg = "Row updated Successfuly!";
                    cmd.Parameters.Add("SIFRA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifra.Text);
                    cmd.Parameters.Add("NAZIV", OracleDbType.Varchar2, 50).Value = txtNaziv.Text;
                    cmd.Parameters.Add("TEZINA", OracleDbType.Double, 9).Value = Double.Parse(txtTezina.Text);
                    cmd.Parameters.Add("PRIMENA", OracleDbType.Varchar2, 50).Value = txtPrimena.Text;
                    cmd.Parameters.Add("ROK", OracleDbType.Int32, 10).Value = Int32.Parse(numRok.Text);
                    cmd.Parameters.Add("CENA", OracleDbType.Double, 9).Value = Double.Parse(txtCenaKostanja.Text);
                    break;
                case 2:
                    msg = "Row deleted Successfuly!";
                    cmd.Parameters.Add("SIFRA", OracleDbType.Int32, 10).Value = Int32.Parse(txtSifra.Text);
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
            string sql = "INSERT INTO ARTIKAL (SIFRA, NAZIV, TEZINA, OPISPROIZVODA, CENA, AKTUELNACENA)" +
                " VALUES (:SIFRAMAGACINA, :NAZIV, tezina(:TEZINA), opis_artikla(:PRIMENA,:ROK), :CENA, 0)";
            this.AUD(sql, 0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSifra.Text = "";
            txtNaziv.Text = "";
            txtCenaKostanja.Text = "";
            txtPrimena.Text = "";
            numRok.Value = 0;
            txtTezina.Text = "";
        }
    }
}
