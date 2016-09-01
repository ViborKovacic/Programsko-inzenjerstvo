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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PICvjecara
{
    public partial class frmProdaja : Form
    {
        public DBClass.Artikl artikli;
        public List<DBClass.Artikl> lista;
        public DBClass.Stavka_racuna stavke;
        public List<DBClass.Stavka_racuna> listaStavke;
        public DBClass.Vrsta_artikla vrsteArtikla;
        public List<DBClass.Vrsta_artikla> listaVrste;
        public Korisnici korisnik = new Korisnici();
        public List<Korisnici> listaKorisnika;
        public List<int> pomocna = new List<int>();

        public frmProdaja()
        {
            korisnik = new Korisnici();
            InitializeComponent();
            ControlBox = false;
        }

        private void listaArtikla(string listaProdaja)
        {
            lista = new List<DBClass.Artikl>();
            lista = DBClass.Artikl.DohvatiArtikleProdaja(listaProdaja);

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

            //Slike();
            OsvijeziStavke();
            
        }

        //public void Slike()
        //{
        //    listaVrste = new List<DBClass.Vrsta_artikla>();
        //    vrsteArtikla = new DBClass.Vrsta_artikla();
        //    listaVrste = vrsteArtikla.DohvatiVrstuUrlArtikla();

        //    foreach (DBClass.Vrsta_artikla item in listaVrste)
        //    {
        //        flowLayoutPanel1.Controls.Add(StvaranjePanela(item.Vrsta.ToString(), item.Url.ToString()));
        //    }

        //}

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
            //this.stavke_racunaTableAdapter.Fill(this._16027_DBDataSet.Stavke_racuna);

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lista = new List<DBClass.Artikl>();
            if (txtBrojArtikla.Text != "") { 
                lista = DBClass.Artikl.DohvatiBrojArtikla(int.Parse(txtBrojArtikla.Text));
                dgvPopisArtikla.DataSource = lista;                
            }
            else
            {
                lista = DBClass.Artikl.DohvatiSveArtikle();
                dgvPopisArtikla.DataSource = lista;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int kolicina = 1;
            int brojac = 0;
            int kolicinaIznos = 0;
            int iznos = 0;
            int suma = 0;
            int ukupno = 0;

            lista = new List<DBClass.Artikl>();
            if (dgvPopisArtikla.SelectedRows.Count > 0)
            {
                int odabraniArtikl = int.Parse(dgvPopisArtikla.SelectedCells[0].Value.ToString());
                lista = DBClass.Artikl.DohvatiArtikle(odabraniArtikl);
            }

            stavke = new DBClass.Stavka_racuna();                    
            stavke.Naziv = lista[0].Naziv;
            stavke.Iznos = int.Parse(lista[0].Cijena.ToString());
            stavke.ID_korisnika = 1;
            stavke.ID_artikli = lista[0].ID_artikla;

            if (pomocna.Count > 0)
            {
                for (int i = 0; i < pomocna.Count; i++)
                {
                    if (pomocna[i] == lista[0].ID_artikla)
                    {
                        stavke.Update();
                        brojac++;
                        listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();                        
                    }
                }

                if (brojac<=0)
                {
                    stavke.Kolicina = kolicina;
                    stavke.Unos();
                    pomocna.Add(lista[0].ID_artikla);
                    listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();
                }      
            }

            else
            {
                stavke.Kolicina = kolicina;
                stavke.Unos();
                pomocna.Add(lista[0].ID_artikla);
                listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();
            }           
            
            
            dgvStavkeRacuna.DataSource = listaStavke;

            for (int i = 0; i < dgvStavkeRacuna.RowCount; i++)
            {
                kolicinaIznos = int.Parse(dgvStavkeRacuna.Rows[i].Cells[4].Value.ToString());
                iznos = int.Parse(dgvStavkeRacuna.Rows[i].Cells[6].Value.ToString());
                suma = kolicinaIznos * iznos;
                ukupno = ukupno + suma;
            }

            lblIznos.Text = ukupno.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lista = new List<DBClass.Artikl>();
            if (txtNazivArtikla.Text != "")
            {
                lista = DBClass.Artikl.DohvatiNazivArtikla(txtNazivArtikla.Text);
                dgvPopisArtikla.DataSource = lista;
            }
            else
            {
                lista = DBClass.Artikl.DohvatiSveArtikle();
                dgvPopisArtikla.DataSource = lista;
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            stavke = new DBClass.Stavka_racuna();
            int obrisiStavke = 0;

            if (MessageBox.Show("Želite li obrisati stavku?", "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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

        private void btnGotovo_Click_1(object sender, EventArgs e)
        {
            listaStavke = new List<DBClass.Stavka_racuna>();
            listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();

 
            int broj = 2256;
            int suma = 0;



            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Racun.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.Image slika = iTextSharp.text.Image.GetInstance("C: /Users/Raingla/Documents/GitHub/r16027/PICvjecara/Slike/logo.png");
            slika.ScalePercent(25f);
            doc.Add(slika);

            Paragraph paragraph = new Paragraph("This is my firs line using Paragraph: \n Novi red");
            paragraph.Alignment = 2;

            doc.Add(paragraph);

            korisnik.AktivanKorisnik();
            
            List list = new List();
            list.Add("Ime izdavaca: " + korisnik.Ime);
            list.Add("Prezime izdavaca: " + korisnik.Prezime);
            list.Add("Datum: " + listaStavke[0].Datum.ToString());
            list.Add("Način plaćanja: " + "Gotovina");
            doc.Add(list);


            PdfPTable tablica = new PdfPTable(5);

            PdfPCell cell = new PdfPCell(new Phrase("Racun br: " + broj));
            cell.Colspan = 5;
            cell.HorizontalAlignment = 1; // 0 - lijevo 1 - sredina 2 - desno
            tablica.AddCell(cell);

            tablica.AddCell("Broj stavke");
            tablica.AddCell("Broj artikla");
            tablica.AddCell("Naziv");
            tablica.AddCell("Kolicina");
            tablica.AddCell("Iznos");
            

            for (int i = 0; i < listaStavke.Count; i++)
            {
                tablica.AddCell(listaStavke[i].ID_stavke_racuna.ToString());
                tablica.AddCell(listaStavke[i].ID_artikli.ToString());
                tablica.AddCell(listaStavke[i].Naziv);
                tablica.AddCell(listaStavke[i].Kolicina.ToString());
                tablica.AddCell(listaStavke[i].Iznos.ToString() + " kn");
                suma = suma + int.Parse(listaStavke[i].Iznos.ToString());
            }
                 
            tablica.HorizontalAlignment = 1;

            PdfPCell cellUkupno = new PdfPCell(new Phrase("Ukupno:"));
            cellUkupno.Colspan = 4;
            cellUkupno.HorizontalAlignment = 2; // 0 - lijevo 1 - sredina 2 - desno
            tablica.AddCell(cellUkupno);

            tablica.AddCell(suma.ToString() + " kn");

            doc.Add(tablica);

            doc.Close();

            stavke = new DBClass.Stavka_racuna();
            stavke.ObrisiSve();

            OsvijeziStavke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stavke = new DBClass.Stavka_racuna();
            stavke.ObrisiSve();

            //int kolicinaRrobe;
            //int brojArtikla;

            //for (int i = 0; i < listaStavke.Count; i++)
            //{
            //    kolicinaRrobe = listaStavke[i].Kolicina;
            //    brojArtikla = listaStavke[i].ID_artikli;
            //    stavke.UmanjiKolicinuArtikli(kolicinaRrobe, brojArtikla);
            //}
            OsvijeziStavke();
        }
    }
}
