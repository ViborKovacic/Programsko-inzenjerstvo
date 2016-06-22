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
    public partial class frmDodajVrstuRezervacije : Form
    {
        DBClass.Tip_rezervacije vrstaRezervacije;
        public int broj = 0;
        public frmDodajVrstuRezervacije( )
        {


            ControlBox = false;
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            vrstaRezervacije = new DBClass.Tip_rezervacije();
            vrstaRezervacije.Vrsta = txtVrstaRezevacije.Text;
            vrstaRezervacije.DohvatiIzBazeVrsta();
            if (vrstaRezervacije.broj == 0)
            {
                vrstaRezervacije.DodajVrstuRezervacije();
                MessageBox.Show("Nova vrsta rezervacije je dodana!");
            }
            else
            {
                MessageBox.Show("Vrsta već postoji u bazi");
            }

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmRezervacija frmRez = new frmRezervacija();
            frmRez.MdiParent = frmRezervacija.ActiveForm;
            frmRez.Show();
        }

        private void frmDodajVrstuRezervacije_Load(object sender, EventArgs e)
        {

        }
    }
}
