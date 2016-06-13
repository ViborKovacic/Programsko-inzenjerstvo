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
            //btnPrikazNarudzbi.Visible = false;
            //btnNarudzbenica.Visible = false;

            //prikazuje koji je korisnik aktivan
            lblKorisnik.Text = Korisnici.TrenutnoAktivan;
            

           

        }

      

        private void btnKraj_Click(object sender, EventArgs e)
        {
            DatabaseConnection.Instance.Connection.Close();
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
            this.Close();
        }

        private void btnPrikazNarudzbi_Click(object sender, EventArgs e)
        {
            frmPregledNarudzbi openPregledNarudzbi = new frmPregledNarudzbi();
            openPregledNarudzbi.Show();
            this.Close();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            frmRezervacije frmRez = new frmRezervacije();
            frmRez.Show();
            this.Close();
        }
    }
}
