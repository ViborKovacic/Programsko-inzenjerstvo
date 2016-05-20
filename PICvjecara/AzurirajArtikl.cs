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
    public partial class AzurirajArtikl : Form
    {
        private Artikli artikli = null;

        public AzurirajArtikl()
        {
            InitializeComponent();
        }

        public AzurirajArtikl(Artikli odabraniArtikli)
        {
            InitializeComponent();
            artikli = odabraniArtikli;
            ControlBox = false;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int broj = 0;
            if (int.TryParse(txtCijena.Text.Trim(), out broj) && int.TryParse(txtKolicina.Text.Trim(), out broj))
            {
                if (artikli == null)
                {
                    artikli = new Artikli();
                }

                artikli.ID_vrsta_artikla = int.Parse(cmboxTipArtikla.SelectedValue.ToString());
                artikli.Naziv = txtNaziv.Text;
                artikli.Cijena = int.Parse(txtCijena.Text);
                artikli.Kolicina = int.Parse(txtKolicina.Text);
                artikli.Unos();
                this.Close();
            }

            else
            {
                MessageBox.Show("Cijena i količina moraju biti brojevi");
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void AzurirajArtikl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);
            txtNaziv.Focus();
            if(artikli != null)
            {
                txtBrojArtikla.Text = artikli.ID_artikla.ToString();
                cmboxTipArtikla.Text = artikli.ID_vrsta_artikla.ToString();
                txtNaziv.Text = artikli.Naziv;
                txtCijena.Text = artikli.Cijena.ToString();
                txtKolicina.Text = artikli.Kolicina.ToString();
            }   
        }
    }
}
