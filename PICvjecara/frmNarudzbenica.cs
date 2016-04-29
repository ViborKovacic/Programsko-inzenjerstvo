using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace PICvjecara
{
    public partial class frmNarudzbenica : Form
    {
        private DBOperacije.OperacijeNarudzba Narudzbenica = new DBOperacije.OperacijeNarudzba();
        
        public frmNarudzbenica()
        {
            InitializeComponent();
            grpBoxNovi.Enabled = false;
            //grpBoxPostojeci.Enabled = false;
            grpBoxZavrseno.Enabled = false;
            DohvatiVrsteArtikla();
            
            
        }

        private void frmNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this._16027_DBDataSet.Narudzbenica);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.Fill(this._16027_DBDataSet.Dobavljaci);

        }

        private void btnPostojeciArtikl_Click(object sender, EventArgs e)
        {
            grpBoxPostojeci.Enabled = true;
            if (grpBoxNovi.Enabled)
            {
                grpBoxNovi.Enabled = false;
            }
        }

        private void btnNoviArtikli_Click(object sender, EventArgs e)
        {
            grpBoxNovi.Enabled = true;
            if (grpBoxPostojeci.Enabled)
            {
                grpBoxPostojeci.Enabled = false;
            }
        }

        private void btnIzradinalogPostojeci_Click(object sender, EventArgs e)
        {
            //treba podesiti login da ovo radi
            DBOperacije.OperacijeNarudzba narudzba = new DBOperacije.OperacijeNarudzba();
            
        }

        private void DohvatiVrsteArtikla()
        {
            cmbVrstaArtikla.Items.Clear();
            SqlDataReader dr;
            string q = "select Vrsta from Vrsta_artikla";
            db baza = new db();

            SqlCommand comm = new SqlCommand(q, baza.conn);
            baza.OpenCon();
            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cmbVrstaArtikla.Items.Add(dr[0].ToString());

            }
            dr.Close();

            
        }
        private void PopuniArtikle()
        {
            string q = "select Artikli.Naziv from Artikli, Vrsta_artikla where Vrsta_artikla.ID_vrsta_artikla=Artikli.ID_vrsta_artikla and Vrsta_artikla.Vrsta='" + cmbVrstaArtikla.SelectedItem.ToString() + "'";

            SqlDataReader dr;
            cmbNazivArtikla.Items.Clear();
            
            db baza = new db();
            
            SqlCommand comm = new SqlCommand(q,baza.conn);
            baza.OpenCon();
            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cmbNazivArtikla.Items.Add(dr[0].ToString());
            }
            dr.Close();
            baza.CloseCon();



        }

        private void cmbVrstaArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniArtikle();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna frmCvijece = new frmCvjecarna();
            frmCvijece.Visible = true;
            this.Close();
        }
    }
}
