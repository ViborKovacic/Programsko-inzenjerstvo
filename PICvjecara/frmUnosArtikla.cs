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
    public partial class frmUnosArtikla : Form
    {
        private DBClass.Artikli artikli = null;

        public frmUnosArtikla()
        {
            InitializeComponent();
            ControlBox = false;
        }

        public frmUnosArtikla(DBClass.Artikli odabraniArtikli)
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
            float broj = 0;
            if (float.TryParse(txtCijena.Text.Trim(), out broj))
            {
                if (artikli == null)
                {
                    artikli = new DBClass.Artikli();
                }

                artikli.ID_vrsta_artikla = int.Parse(cmboxTipArtikla.SelectedValue.ToString());
                artikli.Naziv = txtNaziv.Text;
                artikli.Cijena = float.Parse(txtCijena.Text);
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
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.FillByVrsta(this._16027_DBDataSet.Vrsta_artikla);
        }
    }
}
