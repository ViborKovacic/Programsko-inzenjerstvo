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

namespace PICvjecara
{
    public partial class Registracija : Form
    {
        private Korisnici korisnici = null;
        public Registracija()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            korisnici = new Korisnici();

            korisnici.Ime = txtIme.Text;
            korisnici.Prezime = txtPrezime.Text;
            korisnici.Username = txtKorIme.Text;
            korisnici.Password = txtLozinka.Text;
            korisnici.Email = txtEmail.Text;
            korisnici.Grad = txtGrad.Text;
            korisnici.Adresa = txtAdresa.Text;
            korisnici.Telefon = txtTelefon.Text;
            korisnici.ID_tip_korisnika = int.Parse(txtTipKorisnika.Text);
            korisnici.UnosRegistracija();
            this.Close();

            MessageBox.Show("Uspješno ste se registrirali");
            Prijava openPrijava = new Prijava();
            openPrijava.Show();
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Prijava openPrijava = new Prijava();
            openPrijava.Show();
            this.Close();
        }
    }
}
