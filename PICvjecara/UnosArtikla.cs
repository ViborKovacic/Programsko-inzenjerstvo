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
    public partial class UnosArtikla : Form
    {
        public UnosArtikla()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            cmboxTipArtikla.Text = "Odaberi tip";
            txtNaziv.Clear();
            txtCijena.Clear();
            txtKolicina.Clear();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            PregledArtikla openPregledArtikla = new PregledArtikla();
            openPregledArtikla.Show();
            Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            /* otvoriti konekciju sa bazom, dodati vrijednosti u tablicu
            naredba (insert), zatvoriti konekciju s bazom*/
        }
    }
}
