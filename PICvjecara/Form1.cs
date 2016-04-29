using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICvjecara
{
    public partial class frmCvjecarna : Form
    {
        public frmCvjecarna()
        {
            InitializeComponent();
            ControlBox = false;
            btnPrikazNarudzbi.Visible = false;
            btnNarudzbenica.Visible = false;
            //prikazuje koji je korisnik aktivan
            lblKorisnik.Text = Korisnici.TrenutnoAkrivan;
            Korisnici.AktivanKorisnik();

            btnPrikazNarudzbi.Enabled = false; // treba podesit malo bazu podatak

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            PregledArtikla openPregledArtikla = new PregledArtikla();
            openPregledArtikla.Show();
            Visible = false;
        }
        
        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            Prijava openPrijava = new Prijava();
            openPrijava.Show();
            Visible = false;
        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            btnNarudzbenica.Visible = true;
            btnPrikazNarudzbi.Visible = true;
            grpBox.Text = "Narudžbe i Rezervacije";
        }

        private void btnNarudzbenica_Click(object sender, EventArgs e)
        {
            frmNarudzbenica openNarudzbenica = new frmNarudzbenica();
            openNarudzbenica.Show();
            Visible = false;
        }
           
    }
}
