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
    public partial class PregledArtikla : Form
    {
        public PregledArtikla()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna openCvjecarna = new frmCvjecarna();
            openCvjecarna.Show();
            Visible = false;
        }

        private void btnUnosNovogArtikla_Click(object sender, EventArgs e)
        {
            UnosArtikla openUnosArtikla = new UnosArtikla();
            openUnosArtikla.Show();
            //Visible = false;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            /*otvoiti konekciju s bazom, ažurirati podatke naredba (alter),
            zatvoriti konekciju sa bazom*/
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            /*otvoiti konekciju s bazom, obrisati podatke naredba (delete),
            zatvoriti konekciju sa bazom*/
        }
    }
}
