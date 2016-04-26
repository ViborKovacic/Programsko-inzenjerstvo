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
    public partial class frmCvjecarna : Form
    {
        public frmCvjecarna()
        {
            InitializeComponent();
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
    }
}
