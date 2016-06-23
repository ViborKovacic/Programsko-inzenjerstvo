using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace PICvjecara
{
    public partial class frmProdaja : Form
    {
        public DBClass.Artikli artikli;
        public List<DBClass.Artikli> lista;
        public DBClass.Stavke_racuna stavke;
        public List<DBClass.Stavke_racuna> listaStavke;
        public frmProdaja()
        {
            InitializeComponent();
        }

        private void listaArtikla(string listaProdaja)
        {
            lista = new List<DBClass.Artikli>();
            lista = DBClass.Artikli.DohvatiArtikleProdaja(listaProdaja);

            if (lista.Count != 0)
            {
                dgvPopisArtikla.DataSource = lista;
            }
            else
            {
                MessageBox.Show("Trenutno nema na skladištu traženog artikla pod odabranom kategorijom");
            }
        }

        private void frmProdaja_Load(object sender, EventArgs e)
        {
            OsvijeziStavke();
        }

        public void Slike()
        {
            listaStavke = new List<DBClass.Stavke_racuna>();

        }

        public void OsvijeziStavke()
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.FillByVrsta(this._16027_DBDataSet1.Vrsta_artikla);

            // TODO: This line of code loads data into the '_16027_DBDataSet.Stavke_racuna' table. You can move, or remove it, as needed.
            this.stavke_racunaTableAdapter.Fill(this._16027_DBDataSet.Stavke_racuna);

            // TODO: This line of code loads data into the '_16027_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet.Artikli);
            this.stavke_racunaTableAdapter.Fill(this._16027_DBDataSet.Stavke_racuna);
        }

        private void picCvijece_Click(object sender, EventArgs e)
        {
            string proslijedi = "Cvijece";//lblCvijece.Text;
            listaArtikla(proslijedi);
        }

        private void picBuketi_Click(object sender, EventArgs e)
        {
            string proslijedi = lblBuketi.Text;
            listaArtikla(proslijedi);
        }

        private void picAranzmani_Click(object sender, EventArgs e)
        {
            string proslijedi = lblAranzmani.Text;
            listaArtikla(proslijedi);
        }

        private void picSadnica_Click(object sender, EventArgs e)
        {
            string proslijedi = lblSadnice.Text;
            listaArtikla(proslijedi);
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lista = new List<DBClass.Artikli>();
            if (txtBrojArtikla.Text != "") { 
                lista = DBClass.Artikli.DohvatiBrojArtikla(int.Parse(txtBrojArtikla.Text));
                dgvPopisArtikla.DataSource = lista;                
            }
            else
            {
                lista = DBClass.Artikli.DohvatiSveArtikle();
                dgvPopisArtikla.DataSource = lista;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            lista = new List<DBClass.Artikli>();
            if (dgvPopisArtikla.SelectedRows.Count > 0)
            {
                int odabraniArtikl = int.Parse(dgvPopisArtikla.SelectedCells[0].Value.ToString());
                button1.Text = odabraniArtikl.ToString();
                lista = DBClass.Artikli.DohvatiArtikle(odabraniArtikl);
            }
            stavke = new DBClass.Stavke_racuna();           
            stavke.Naziv = lista[0].Naziv;
            stavke.Cijena = int.Parse(lista[0].Cijena.ToString());
            stavke.Kolicina = lista[0].Kolicina;
            stavke.ID_korisnika = 1;
            stavke.ID_artikli = lista[0].ID_artikla;
            stavke.Unos();

            listaStavke = DBClass.Stavke_racuna.DohvatiSveStavke();
            dgvStavkeRacuna.DataSource = listaStavke;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lista = new List<DBClass.Artikli>();
            if (txtNazivArtikla.Text != "")
            {
                lista = DBClass.Artikli.DohvatiNazivArtikla(txtNazivArtikla.Text);
                dgvPopisArtikla.DataSource = lista;
            }
            else
            {
                lista = DBClass.Artikli.DohvatiSveArtikle();
                dgvPopisArtikla.DataSource = lista;
            }
        }

        private Panel StvaranjePanela()
        {
            var panel = new Panel { BackColor = Color.Red };
            panel.Size = new Size(122, 189);
            panel.Controls.Add(new PictureBox { });
            panel.Controls.Add(new Label { Text = "Proba" });
            return panel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(StvaranjePanela());
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            stavke = new DBClass.Stavke_racuna();
            int obrisiStavke = 0;

            if (MessageBox.Show("Želite li obrisati artikl?", "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dgvStavkeRacuna.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dgvStavkeRacuna.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvStavkeRacuna.Rows[selectedRowIndex];
                    obrisiStavke = int.Parse(selectedRow.Cells[0].Value.ToString());
                }
                stavke.Obrisi(obrisiStavke);
                OsvijeziStavke();
            }
        }
    }
}
