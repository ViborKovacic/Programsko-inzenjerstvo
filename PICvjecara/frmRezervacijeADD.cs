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
    public partial class frmRezervacijeADD : Form
    {
        DBClass.Tip_rezervacije VrstaRezervacije;
        DBClass.Rezervacija Rezervacije;
        public frmRezervacijeADD()
        {
            VrstaRezervacije = new DBClass.Tip_rezervacije();
            Rezervacije = new DBClass.Rezervacija();
            InitializeComponent();
        }

        private void frmRezervacijeADD_Load(object sender, EventArgs e)
        {

        }

        private void btnIzradi_Click(object sender, EventArgs e)
        {
            //dodavanje nove vrste
            VrstaRezervacije.Vrsta = txtNovaVrsta.Text;
            VrstaRezervacije.DodajVrstuRezervacije();
            VrstaRezervacije.DohvatiIdVrsteRez();
            //dodavanje rezervacije
            Rezervacije.ID_tip_rezervacije = VrstaRezervacije.ID_tip_rezervacije;
            Rezervacije.Cijena = float.Parse(txtCijena.Text);
            Rezervacije.Opis = txtOpis.Text;
            Rezervacije.Insert();

            MessageBox.Show("Nova vrsta rezervacije je kreirana!");

            
            

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmRezervacije frmRez = new frmRezervacije();
            frmRez.Show();
            this.Close();
        }
    }
}
