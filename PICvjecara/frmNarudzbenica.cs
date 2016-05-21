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
using System.Data.Common;

namespace PICvjecara
{
    public partial class frmNarudzbenica : Form
    {
        DBClass.Narudzbenica Narudzbenica;
        DBClass.Dobavljaci dobavljaci;
        DBClass.StavkeNarudzbenice stavkeNarudzbenice;
        DBClass.Artikli artikli;
        Korisnici korisnici;

        //liste
        List<string> NaruceniArtikli;





        public frmNarudzbenica()
        {
            Narudzbenica = new DBClass.Narudzbenica();
            korisnici = new Korisnici();
            dobavljaci = new DBClass.Dobavljaci();
            stavkeNarudzbenice = new DBClass.StavkeNarudzbenice();
            artikli = new DBClass.Artikli();

            NaruceniArtikli = new List<string>();
           

            InitializeComponent();
            grpBoxNovi.Enabled = false;
            //grpBoxPostojeci.Enabled = false;
            //grpBoxZavrseno.Enabled = false;



            //treba doraditi
            btnEmail.Enabled = false;
            btnPDF.Enabled = false;
            btnNoviArtikli.Enabled = false;






        }

        private void frmNarudzbenica_Load(object sender, EventArgs e)
        {
            DohvatiDobavljace();

            DohvatiArtikle(); //vrsta proizvoda







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

        private void DohvatiDobavljace()
        {
            cmbDobavljac.Items.Clear();
            string q = "select * from Dobavljaci";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                cmbDobavljac.Items.Add(dr["Ime"].ToString());
            }
            dr.Close();



        }

        private void DohvatiArtikle()
        {
            cmbVrstaArtikla.Items.Clear();
            string q = "select Vrsta from Vrsta_artikla";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                cmbVrstaArtikla.Items.Add(dr[0].ToString());
            }
            dr.Close();

        }

        private void PopuniArtikle()//naziv proizvoda
        {
            cmbNazivArtikla.Items.Clear();
            string q = "select Artikli.Naziv from Artikli, Vrsta_artikla where Vrsta_artikla.ID_vrsta_artikla=Artikli.ID_vrsta_artikla and Vrsta_artikla.Vrsta='" + cmbVrstaArtikla.SelectedItem.ToString() + "'";

            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                cmbNazivArtikla.Items.Add(dr[0].ToString());
            }
            dr.Close();
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

        private void btnIzradinalogPostojeci_Click(object sender, EventArgs e)
        {
            string naruceniArtikli = "";
            DateTime datumNarudzbe = DateTime.Now;
            Narudzbenica.kolicina = int.Parse(txtKolicinaPostojeci.Text);

            Narudzbenica.Datum_vrijeme = datumNarudzbe;

            dobavljaci.DohvatiDobavljace();

            Narudzbenica.ID_dobavljac = dobavljaci.ID_dobavljac;
            Narudzbenica.ID_korisnici = korisnici.ID_korisnik;

            artikli.DohvatiID();
            stavkeNarudzbenice.ID_artikla = artikli.ID_artikla;
            Narudzbenica.DohvatiIDNaruzbe();
            stavkeNarudzbenice.ID_narudzbenice = Narudzbenica.ID_narudzbenica+1; //ovdje je +1 jer mi u tablicu stavke narudzbenice sprema uvijek za jedan manje neznam zkj

            
            Narudzbenica.Spremi();
            stavkeNarudzbenice.Insert();


            //ispis u textbox da vidimo sta naruceno
            naruceniArtikli = "Naručeni artikli su: " + Environment.NewLine + "Naziv artikla: " + cmbNazivArtikla.SelectedItem.ToString() +
                Environment.NewLine + "Vrsta artikla: " + cmbVrstaArtikla.SelectedItem.ToString() + Environment.NewLine +
                "Količina: " + txtKolicinaPostojeci.Text.ToString() + Environment.NewLine;
            NaruceniArtikli.Add(naruceniArtikli);
            Ispis();


        }

        private void cmbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {

            dobavljaci.Ime = cmbDobavljac.GetItemText(cmbDobavljac.SelectedItem.ToString());

        }

        private void cmbNazivArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            artikli.Naziv = cmbNazivArtikla.GetItemText(cmbNazivArtikla.SelectedItem.ToString());
           
        }

        private void Ispis()
         {
             foreach (string s in NaruceniArtikli)
             {
                 txtNaruceniArtikli.Clear();
                 txtNaruceniArtikli.Text = s.ToString() + txtNaruceniArtikli.Text;

             }
             MessageBox.Show("Narudžba je kreirana i pohranjena!");
         }
    }
}
