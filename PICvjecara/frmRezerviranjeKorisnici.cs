using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICvjecara
{
    public partial class frmRezerviranjeKorisnici : Form
    { Korisnici korisnik;
        DBClass.Kupci kupci;
        DBClass.Nalog_za_prodaju NalogZaprodaju;
        DBClass.Stavke_rezervacije StavkeRezervacije;
        DBClass.Rezervacija Rezervacija;
        DBClass.Tip_rezervacije VrstaRezervacije;
        public frmRezerviranjeKorisnici(int kolicina)
        {

            kupci = new DBClass.Kupci();
            NalogZaprodaju = new DBClass.Nalog_za_prodaju();
            StavkeRezervacije = new DBClass.Stavke_rezervacije();
            Rezervacija = new DBClass.Rezervacija();
            VrstaRezervacije = new DBClass.Tip_rezervacije();
            korisnik = new Korisnici();
            StavkeRezervacije.Kolicina = kolicina;
            InitializeComponent();
        }

        private void frmRezerviranjeKorisnici_Load(object sender, EventArgs e)
        {
            btnRezerviraj.Enabled = false;
            grbKupac.Enabled = false;
            btnUnesiKupca.Enabled = true;
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            #region Provjera
            ///<summary>
            ///Ovdje se provjerava da li klijent postoji u bazi 
            ///</summary>

            Int64 OIB = 0;
            string uneseniOIB = txtOIB.Text;
            if (long.TryParse(uneseniOIB, out OIB))
            {
                kupci.OIB = txtOIB.Text;
                kupci.DohvatiIzBaze();
                grbKupac.Enabled = true;
                if (kupci.broj == 0)
                {
                    MessageBox.Show("Klijent ne postoji u bazi, unesite ga!");
                    txtIme.Text = "";
                    txtPrezime.Text = "";
                    txtAdresa.Text = "";
                    txtEmail.Text = ""; ;
                    txtTelefon.Text = "";
                    btnUnesiKupca.Enabled = true;
                    btnKupacPromjene.Enabled = false;
                    kupci.BrisiSadrzajClasse();
                }
                else
                {
                    txtIme.Text = kupci.Ime;
                    txtPrezime.Text = kupci.Prezime;
                    txtAdresa.Text = kupci.Adresa;
                    txtEmail.Text = kupci.Email;
                    txtTelefon.Text = kupci.Telefon;
                    btnUnesiKupca.Enabled = false;
                    
                    kupci.broj = 0;
                    btnRezerviraj.Enabled = true;
                }


            }
            else
            {
                MessageBox.Show("krivo unesen OIB!");
            }
            #endregion

           
        }

        private void btnUnesiKupca_Click(object sender, EventArgs e)
        {
            //punjenje klase novim podacima
            UpdateClassVarijable();


            kupci.Insert();
            MessageBox.Show("Klijent je uspješno unesen!");
            btnRezerviraj.Enabled = true;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmRezervacije frmRez = new frmRezervacije();
            frmRez.Show();
            this.Close();
        }

        private void btnKupacPromjene_Click(object sender, EventArgs e)
        {
            UpdateClassVarijable();
            kupci.Update();
            MessageBox.Show("Korisnik je ažuriran!");
        }
        /// <summary>
        /// ove metoda sluzi za update, koristi se isti code na vise mjesta pa da se smanji 
        /// </summary>
        private void UpdateClassVarijable()
        {
            kupci.Ime = txtIme.Text;
            kupci.Prezime = txtPrezime.Text;
            kupci.OIB = txtOIB.Text;
            kupci.Email = txtEmail.Text;
            kupci.Adresa = txtAdresa.Text;
            kupci.Telefon = txtTelefon.Text;
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            DateTime datumNarudzbe = DateTime.Now;
            //punjenje klase nalog_za_prodaju
            NalogZaprodaju.Datum = datumNarudzbe;
            korisnik.AktivanKorisnik();
            NalogZaprodaju.ID_korisnik = korisnik.ID_korisnik;
            NalogZaprodaju.ID_kupci = kupci.ID_kupca;
            NalogZaprodaju.Insert();
            //punjenje klase Stavke_rezervacije
            NalogZaprodaju.DohvatiIdNaloga();
            StavkeRezervacije.ID_nalog_za_prodaju = NalogZaprodaju.ID_nalog_za_prodaju;
            Rezervacija.DohvatiIdRezervacije();
            StavkeRezervacije.ID_rezervacija = Rezervacija.ID_rezervacije;
            
            StavkeRezervacije.Insert();
            MessageBox.Show("Rezervacija je spremljena!");
            




        }
    }
}
