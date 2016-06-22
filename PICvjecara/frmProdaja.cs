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
            // TODO: This line of code loads data into the '_16027_DBDataSet.Stavke_racuna' table. You can move, or remove it, as needed.
            this.stavke_racunaTableAdapter.Fill(this._16027_DBDataSet.Stavke_racuna);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet.Artikli);


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
            if (textBox1.Text != "") { 
                lista = DBClass.Artikli.DohvatiBrojArtikla(int.Parse(textBox1.Text));
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
            List<DBClass.Stavke_racuna> lista = new List<DBClass.Stavke_racuna>();
            if (dgvPopisArtikla.SelectedRows.Count > 0)
            {
                int odabraniArtikl = int.Parse(dgvPopisArtikla.SelectedCells[0].Value.ToString());
                lista = DBClass.Stavke_racuna.DohvatiOznaceneArtikle(odabraniArtikl);
            }

            //stavke.ID_stavke_racuna = lista[0].ID_stavke_racuna;
            stavke.Naziv = lista[0].Naziv;
            stavke.Cijena = lista[0].Cijena;
            stavke.Kolicina = lista[0].Kolicina;
            stavke.Datum = lista[0].Datum;
            stavke.ID_korisnika = lista[0].ID_korisnika;
            stavke.ID_artikli = lista[0].ID_artikli;
            stavke.Unos();
            dgvStavkeRacuna.DataSource = DBClass.Stavke_racuna.DohvatiSveStavke();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lista = new List<DBClass.Artikli>();
            if (textBox2.Text != "")
            {
                lista = DBClass.Artikli.DohvatiNazivArtikla(textBox2.Text);
                dgvPopisArtikla.DataSource = lista;
            }
            else
            {
                lista = DBClass.Artikli.DohvatiSveArtikle();
                dgvPopisArtikla.DataSource = lista;
            }
        }
    }
}
