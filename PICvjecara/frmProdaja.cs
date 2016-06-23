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
        public DBClass.Vrste_artikla vrsteArtikla;
        public List<DBClass.Vrste_artikla> listaVrste;

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

            Slike();
            OsvijeziStavke();
            
        }

        public void Slike()
        {
            listaVrste = new List<DBClass.Vrste_artikla>();
            vrsteArtikla = new DBClass.Vrste_artikla();
            listaVrste = vrsteArtikla.DohvatiVrstuUrlArtikla();

            foreach (DBClass.Vrste_artikla item in listaVrste)
            {
                flowLayoutPanel1.Controls.Add(StvaranjePanela(item.Vrsta.ToString(), item.Url.ToString()));
            }

        }

        public void OsvijeziStavke()
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this._16027_DBDataSet1.Korisnici);

            // TODO: This line of code loads data into the '_16027_DBDataSet1.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.FillByVrsta(this._16027_DBDataSet1.Vrsta_artikla);

            // TODO: This line of code loads data into the '_16027_DBDataSet.Stavke_racuna' table. You can move, or remove it, as needed.
            this.stavke_racunaTableAdapter.Fill(this._16027_DBDataSet.Stavke_racuna);

            // TODO: This line of code loads data into the '_16027_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet.Artikli);
            this.stavke_racunaTableAdapter.Fill(this._16027_DBDataSet.Stavke_racuna);
            
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

        private Panel StvaranjePanela(string listaVrste, string url)
        {
            Panel panel = new Panel();
            panel.Size = new Size(122, 189);
            panel.Location = new Point(0, 0);

            Label label = new Label();
            label.Text = listaVrste;
            label.Location = new Point(38, 160);

            PictureBox picture = new PictureBox();
            picture.Name = "pictureBox1";
            picture.Location = new Point(3,3);
            picture.Size = new Size(114, 139);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Load(url);
            picture.Refresh();
            picture.Visible = true;

            label2.Text = picture.Name;

            panel.Controls.Add(picture);         
            panel.Controls.Add(label);
            return panel;
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
                    stavke.Obrisi(obrisiStavke);
                    OsvijeziStavke();
                }
                else
                {
                    MessageBox.Show("Nema podataka u tablici");
                }
                
            }
        }

        
    }
}
