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
    public partial class frmNarudzbenica : Form
    {
        
        public frmNarudzbenica()
        {
            InitializeComponent();
            grpBoxNovi.Enabled = false;
            grpBoxPostojeci.Enabled = false;
            grpBoxZavrseno.Enabled = false;
            
        }

        private void frmNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.Fill(this._16027_DBDataSet.Dobavljaci);

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
    }
}
