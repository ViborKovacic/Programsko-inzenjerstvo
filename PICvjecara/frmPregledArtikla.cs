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
using System.IO;

namespace PICvjecara
{
    public partial class frmPregledArtikla : Form
    {
        public DBClass.Artikl artikli;
        public DBClass.Vrsta_artikla vrstaArtikla;
        public OpenFileDialog fileDialog;
        public List<DBClass.Vrsta_artikla> listaVsrtaArtikla = new List<DBClass.Vrsta_artikla>();
        public frmPregledArtikla()
        {
            InitializeComponent();
            ControlBox = false;
        }

        public void OsvijeziArtikle()
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter1.FillByVrsta(this._16027_DBDataSet1.Vrsta_artikla);
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter1.FillByVrsta(this._16027_DBDataSet1.Artikli);
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna openCvjecarna = new frmCvjecarna();
            openCvjecarna.ShowDialog();
            this.Close();
        }

        private void btnUnosNovogArtikla_Click(object sender, EventArgs e)
        {
            gboxUnosAzur.Enabled = true;
            gboxUnosAzur.Text = "Unos novog artikla";
            groupBox1.Enabled = false;
            btnAzuriraj.Enabled = false;
            btnUnosNovogArtikla.Enabled = false;
            btnPovratak.Enabled = false;
            btnBrisi.Enabled = false;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            List<DBClass.Artikl> lista = new List<DBClass.Artikl>();
            if (artikliDataGridView.SelectedRows.Count > 0)
            {
                int odabraniArtikl = int.Parse(artikliDataGridView.SelectedCells[0].Value.ToString());                
                lista = DBClass.Artikl.DohvatiArtikle(odabraniArtikl);
            }

            gboxUnosAzur.Enabled = true;
            gboxUnosAzur.Text = "Azuriranje artikla";
            groupBox1.Enabled = false;
            btnAzuriraj.Enabled = false;
            btnUnosNovogArtikla.Enabled = false;
            btnPovratak.Enabled = false;
            btnBrisi.Enabled = false;

            cmboxTipArtikla.DisplayMember = lista[0].ID_vrsta_artikla.ToString();
            txtNaziv.Text = lista[0].Naziv;
            txtCijena.Text = lista[0].Cijena.ToString();
            txtKolicina.Text = lista[0].Kolicina.ToString();

            btnDodaj.Text = "Ažuriraj";
            OsvijeziArtikle();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            artikli = new DBClass.Artikl();
            int obrisiArikl = 0;

            if (MessageBox.Show("Želite li obrisati artikl?" , "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (artikliDataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = artikliDataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];
                    obrisiArikl = int.Parse(selectedRow.Cells[0].Value.ToString());
                }

                artikliDataGridView.Rows.RemoveAt(artikliDataGridView.CurrentRow.Index);   
                artikli.Obrisi(obrisiArikl);
            }
            OsvijeziArtikle();
        }

        private void artikliDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (artikliDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = artikliDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];
                txtBrisanjeArtikla.Text = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }

        private void PregledArtikla_Load(object sender, EventArgs e)
        {
            OsvijeziArtikle();
            gboxUnosAzur.Enabled = false;
        }

        private void btnSpremi_Click_1(object sender, EventArgs e)
        {
            vrstaArtikla = new DBClass.Vrsta_artikla();
            listaVsrtaArtikla = vrstaArtikla.DohvatiVrstuArtikla();
            int broj = 0;
            for (int i = 0; i < listaVsrtaArtikla.Count; i++)
            {
                if (listaVsrtaArtikla[i].Vrsta == txtVrsta.Text)
                {
                    broj++;
                }
            }
            //int broj = vrstaArtikla.DohvatiVrstuPoID(txtVrsta.Text);
            if (broj == 0)
            {
                vrstaArtikla.Vrsta = txtVrsta.Text;
                vrstaArtikla.Unos();
                OsvijeziArtikle();
            }
            else
            {
                MessageBox.Show("Kategorija vec postoji");
            }
        }

        private void btnPovratak1_Click(object sender, EventArgs e)
        {
            gboxUnosAzur.Enabled = false;
            gboxUnosAzur.Text = "";
            btnDodaj.Text = "Dodaj";
            groupBox1.Enabled = true;
            btnAzuriraj.Enabled = true;
            btnUnosNovogArtikla.Enabled = true;
            btnPovratak.Enabled = true;
            btnBrisi.Enabled = true;

            cmboxTipArtikla.Text = "Odaberi tip";
            txtNaziv.Text = "Naziv artikla";
            txtCijena.Text = "Unesite cijenu u kn";
            txtKolicina.Text = "Unesite količinu";

            OsvijeziArtikle();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (btnDodaj.Text == "Dodaj")
            {
                float broj = 0;
                if (float.TryParse(txtCijena.Text.Trim(), out broj))
                {
                    if (artikli == null)
                    {
                        artikli = new DBClass.Artikl();
                    }

                    artikli.ID_vrsta_artikla = int.Parse(cmboxTipArtikla.SelectedValue.ToString());
                    artikli.Naziv = txtNaziv.Text;
                    artikli.Cijena = float.Parse(txtCijena.Text);
                    artikli.Kolicina = int.Parse(txtKolicina.Text);
                    artikli.Unos();
                }
                else
                {
                    MessageBox.Show("Cijena i količina moraju biti brojevi");
                }
            }

            else
            {
                int broj = 0;
                if (int.TryParse(txtCijena.Text.Trim(), out broj) && int.TryParse(txtKolicina.Text.Trim(), out broj))
                {
                    if (artikli == null)
                    {
                        artikli = new DBClass.Artikl();
                    }

                    artikli.ID_vrsta_artikla = int.Parse(cmboxTipArtikla.SelectedValue.ToString());
                    artikli.Naziv = txtNaziv.Text;
                    artikli.Cijena = int.Parse(txtCijena.Text);
                    artikli.Kolicina = int.Parse(txtKolicina.Text);
                    artikli.Unos();
                }

                else
                {
                    MessageBox.Show("Cijena i količina moraju biti brojevi");
                }
            }           

            OsvijeziArtikle();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            cmboxTipArtikla.Text = "Odaberi tip";
            txtNaziv.Text = "Naziv artikla";
            txtCijena.Text = "Unesite cijenu u kn";
            txtKolicina.Text = "Unesite količinu";
        }
    }
}
