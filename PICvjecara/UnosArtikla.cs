using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PICvjecara
{
    public partial class UnosArtikla : Form
    {
        private Artikli artikli = null;

        public UnosArtikla()
        {
            InitializeComponent();
            ControlBox = false;
        }

        public UnosArtikla(Artikli odabraniArtikli)
        {
            InitializeComponent();
            artikli = odabraniArtikli;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            cmboxTipArtikla.Text = "Odaberi tip";
            txtNaziv.Text = "Naziv artikla";
            txtCijena.Text = "Unesite cijenu u kn";
            txtKolicina.Text = "Unesite količinu";
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int broj = 0;
            if (int.TryParse(txtCijena.Text.Trim(), out broj))
            {
                if (artikli == null)
                {
                    artikli = new Artikli();
                }

                artikli.ID_vrsta_artikla = int.Parse(cmboxTipArtikla.Text);
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

        private void UnosArtikla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet.Artikli);

        }
    }
}
