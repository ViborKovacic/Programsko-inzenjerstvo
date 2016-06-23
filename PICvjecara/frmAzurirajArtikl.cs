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
    public partial class frmAzurirajArtikl : Form
    {
        private DBClass.Artikl artikli;
        public List<DBClass.Artikl> lista;

        public frmAzurirajArtikl()
        {
            InitializeComponent();
        }

        public frmAzurirajArtikl(List<DBClass.Artikl> lista)
        {
            InitializeComponent();
            this.lista = lista;
            ControlBox = false;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int broj = 0;
            if (int.TryParse(txtCijena.Text.Trim(), out broj) && int.TryParse(txtKolicina.Text.Trim(), out broj))
            {
                if (artikli == null)
                {
                    artikli = new DBClass.Artikl();
                }

                artikli.ID_artikla = int.Parse(txtBrojArtikla.Text);
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
            this.vrsta_artiklaTableAdapter.FillByVrsta(this._16027_DBDataSet.Vrsta_artikla);
            
            if (lista != null)
            {

                txtBrojArtikla.Text = lista[0].ID_artikla.ToString();
                cmboxTipArtikla.DisplayMember = lista[0].ID_vrsta_artikla.ToString();
                txtNaziv.Text = lista[0].Naziv.ToString();
                txtCijena.Text = lista[0].Cijena.ToString();
                txtKolicina.Text = lista[0].Kolicina.ToString();
            }   
        }
    }
}
