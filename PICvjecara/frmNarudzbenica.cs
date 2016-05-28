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
        DBClass.Vrste_artikla vrstaArtikla;

        //liste
        List<string> NaruceniArtikli;

        //varijable
        bool provjera = false;//sluzi da znamo kod narucivanja novih artikla da li je izabrana postojeca vrsta artikla il dodajemo novu
        bool provjeraDobavljaca = false;//isto sam za dobavljace




        public frmNarudzbenica()
        {
            Narudzbenica = new DBClass.Narudzbenica();
            korisnici = new Korisnici();
            dobavljaci = new DBClass.Dobavljaci();
            stavkeNarudzbenice = new DBClass.StavkeNarudzbenice();
            artikli = new DBClass.Artikli();
            vrstaArtikla = new DBClass.Vrste_artikla();

            NaruceniArtikli = new List<string>();


            InitializeComponent();
            grpBoxNovi.Enabled = false;
            
            //treba doraditi
            btnEmail.Enabled = false;
            btnPDF.Enabled = false;







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
            cmbDobavljacNovi.Items.Clear();
            string q = "select * from Dobavljaci";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                cmbDobavljac.Items.Add(dr["Ime"].ToString());
                cmbDobavljacNovi.Items.Add(dr["Ime"].ToString());
            }
            dr.Close();



        }

        private void DohvatiArtikle()
        {
            cmbVrstaArtikla.Items.Clear();
            cmbVrstaArtiklaNovi.Items.Clear();
            string q = "select Vrsta from Vrsta_artikla";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                cmbVrstaArtikla.Items.Add(dr[0].ToString());
                cmbVrstaArtiklaNovi.Items.Add(dr[0].ToString());
                
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
           

           
            Narudzbenica.Spremi();
           
            Narudzbenica.DohvatiIDNaruzbe();
            stavkeNarudzbenice.ID_artikla = artikli.ID_artikla;
            stavkeNarudzbenice.ID_narudzbenice = Narudzbenica.ID_narudzbenica  ; //ovdje je +1 jer mi u tablicu stavke narudzbenice sprema uvijek za jedan manje neznam zkj


            
            stavkeNarudzbenice.Insert();


            //ispis u textbox da vidimo sta naruceno
            naruceniArtikli = "Naručeni artikli su: " + Environment.NewLine + "Naziv artikla: " + cmbNazivArtikla.SelectedItem.ToString() +
                Environment.NewLine + "Vrsta artikla: " + cmbVrstaArtikla.SelectedItem.ToString() + Environment.NewLine +
                "Količina: " + txtKolicinaPostojeci.Text.ToString() + Environment.NewLine;
            NaruceniArtikli.Add(naruceniArtikli);
            Ispis();


        }

        

        

        private void btnIzradiNalogNovi_Click(object sender, EventArgs e)
        {
            //popunjavanje klase Dobavljaci
            PopuniClasuDobavljaci();
            
            PopunaClaseArtikli();
            artikli.DodajArtikl();

            //upis u klasu Narudzbenice
            DateTime datumNarudzbe = DateTime.Now;
            Narudzbenica.Datum_vrijeme = datumNarudzbe;
            Narudzbenica.ID_korisnici = korisnici.ID_korisnik;
            dobavljaci.DohvatiIDDobavljaca();
            Narudzbenica.ID_dobavljac = dobavljaci.ID_dobavljac;
            Narudzbenica.kolicina = int.Parse(txtKolicinaNovog.Text);
            Narudzbenica.Spremi();
            
            //upis u klasu StavkeNarudzbenice
            artikli.DohvatiIDNovogArtikla();
            Narudzbenica.DohvatiIDNaruzbe();
            stavkeNarudzbenice.ID_artikla = artikli.ID_artikla;
            stavkeNarudzbenice.ID_narudzbenice = Narudzbenica.ID_narudzbenica ;
            
            stavkeNarudzbenice.Insert();




        }
        /// <summary>
        /// Metoda sluzi za popunjavanje klase artikli
        /// if nam sluzi da znamo dal dodajemo novu vrstu artikla il uzimamo postojecu
        /// </summary>
        private void PopunaClaseArtikli()
        {
            

            if (provjera)
            {
                
                vrstaArtikla.Vrsta = cmbVrstaArtiklaNovi.SelectedItem.ToString();
                vrstaArtikla.DohvatiIDVrsteArtikla();

                //punjenje klase DBClass.Artikli
                artikli.Naziv = txtProizvod.Text;
                artikli.Cijena = int.Parse(txtCijenaArtikla.Text.ToString());
                artikli.Kolicina = int.Parse(txtKolicinaNovog.Text.ToString());
                artikli.ID_vrsta_artikla = vrstaArtikla.ID_vrsta_artikla;
              


            }
            else
            {
                
                vrstaArtikla.Vrsta = txtVrstaArtikla.Text;
                vrstaArtikla.DodajNovuVrstu();
                vrstaArtikla.DohvatiNoviID();

                artikli.Naziv = txtProizvod.Text;
                artikli.Cijena = int.Parse(txtCijenaArtikla.Text.ToString());
                artikli.Kolicina = int.Parse(txtKolicinaNovog.Text.ToString());
                artikli.ID_vrsta_artikla = vrstaArtikla.ID_vrsta_artikla;
                



            }
            

        }
        private void PopuniClasuDobavljaci()
        {
            if (provjeraDobavljaca)
            {
                dobavljaci.Ime = txtDobavljac.Text;
                dobavljaci.OIB = txtOIB.Text;
                dobavljaci.Telefon = txtTelefon.Text;
                dobavljaci.Adresa = txtAdresa.Text;
                dobavljaci.DodajDobavljaca();
               
            }
            else
            {
                dobavljaci.DohvatiDobavljace();
            }
        }

        

        private void label14_Click(object sender, EventArgs e)
        {
            provjera = false;
            txtVrstaArtikla.Enabled = true;
            cmbVrstaArtiklaNovi.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            provjera = true;
            cmbVrstaArtiklaNovi.Enabled = true;
            txtVrstaArtikla.Enabled = false;
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
        private void cmbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {

            dobavljaci.Ime = cmbDobavljac.GetItemText(cmbDobavljac.SelectedItem.ToString());

        }

        private void cmbNazivArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {

            artikli.Naziv = cmbNazivArtikla.GetItemText(cmbNazivArtikla.SelectedItem.ToString());
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            cmbDobavljacNovi.Enabled = false;
            provjeraDobavljaca = true;
            txtDobavljac.Enabled = true;
            txtOIB.Enabled = true;
            txtTelefon.Enabled = true;
            txtAdresa.Enabled = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            cmbDobavljacNovi.Enabled = true;
            provjeraDobavljaca = false;
            txtDobavljac.Enabled = false;
            txtOIB.Enabled = false;
            txtTelefon.Enabled = false;
            txtAdresa.Enabled = false;
        }
    }
}
