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
using iTextSharp.text.pdf.draw;

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
            OsvijeziStavke();
            lblBrRacuna.Text = 2234.ToString();
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
            bool zastavica = false;
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
                        zastavica = true;
                        listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();

                        
                        int brojArtikla = int.Parse(lista[0].ID_artikla.ToString());
                        DBClass.Artikl.SmanjnjeKolicine(brojArtikla);
                        lista = DBClass.Artikl.DohvatiSveArtikle();
                    }
                }

                if (zastavica != true)
                {
                    stavke.Kolicina = kolicina;
                    stavke.Unos();
                    pomocna.Add(lista[0].ID_artikla);
                    listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();

                    int brojArtikla = int.Parse(lista[0].ID_artikla.ToString());
                    DBClass.Artikl.SmanjnjeKolicine(brojArtikla);
                    lista = DBClass.Artikl.DohvatiSveArtikle();
                }      
            }

            else
            {
                stavke.Kolicina = kolicina;
                stavke.Unos();
                pomocna.Add(lista[0].ID_artikla);
                listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();

                int brojArtikla = int.Parse(lista[0].ID_artikla.ToString());
                DBClass.Artikl.SmanjnjeKolicine(brojArtikla);
                lista = DBClass.Artikl.DohvatiSveArtikle();
            }           
            
            
            dgvStavkeRacuna.DataSource = listaStavke;
            dgvPopisArtikla.DataSource = lista;

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
                int kolicinaIznos = 0;
                int iznos = 0;
                int suma = 0;
                int ukupno = 0;
                int brojArtikla = 0;

                if (dgvStavkeRacuna.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dgvStavkeRacuna.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvStavkeRacuna.Rows[selectedRowIndex];
                    obrisiStavke = int.Parse(selectedRow.Cells[0].Value.ToString());

                    if (int.Parse(selectedRow.Cells[4].Value.ToString()) > 1)
                    {
                        brojArtikla = int.Parse(selectedRow.Cells[2].Value.ToString());
                        stavke.UmanjiKolicinuArtikli(brojArtikla);
                        listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();

                        DBClass.Artikl.PovecanjeKolicine(brojArtikla);
                        lista = DBClass.Artikl.DohvatiSveArtikle();
                    }
                    else
                    {
                        stavke.Obrisi(obrisiStavke);

                        brojArtikla = int.Parse(selectedRow.Cells[2].Value.ToString());
                        DBClass.Artikl.PovecanjeKolicine(brojArtikla);
                        lista = DBClass.Artikl.DohvatiSveArtikle();
                    }

                    listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();
                    dgvStavkeRacuna.DataSource = listaStavke;

                    dgvPopisArtikla.DataSource = lista;

                    for (int i = 0; i < dgvStavkeRacuna.RowCount; i++)
                    {
                        kolicinaIznos = int.Parse(dgvStavkeRacuna.Rows[i].Cells[4].Value.ToString());
                        iznos = int.Parse(dgvStavkeRacuna.Rows[i].Cells[6].Value.ToString());
                        suma = kolicinaIznos * iznos;
                        ukupno = ukupno + suma;
                    }

                    lblIznos.Text = ukupno.ToString();
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

            lista = DBClass.Artikl.DohvatiSveArtikle();
 
            int broj = 2256;
            int suma = 0;

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Racun.pdf", FileMode.Create));
            doc.Open();
    
            iTextSharp.text.Image slika = iTextSharp.text.Image.GetInstance("C:/Users/vibor/Documents/GitHub/r16027/PICvjecara/Slike/logo.png");
            slika.ScalePercent(25f);
            slika.Alignment = 2;
            doc.Add(slika);

            Paragraph paragraph = new Paragraph("Cvijecarna Mak");
            paragraph.Alignment = 1;
            paragraph.Font.SetStyle("bold");

            doc.Add(paragraph);

            korisnik.AktivanKorisnik();
            
            List list = new List();
            list.Add("Ime izdavaca: " + korisnik.Ime);
            list.Add("Prezime izdavaca: " + korisnik.Prezime);
            list.Add("Datum: " + listaStavke[0].Datum.ToString());
            list.Add("Način plaćanja: " + "Gotovina");
            doc.Add(list);

            Paragraph noviRed = new Paragraph("\n\n");
            doc.Add(noviRed);

            PdfPTable tablica = new PdfPTable(6);

            PdfPCell cell = new PdfPCell(new Phrase("Racun br: " + broj));
            cell.Colspan = 6;
            cell.HorizontalAlignment = 1; // 0 - lijevo 1 - sredina 2 - desno
            tablica.AddCell(cell);

            tablica.AddCell("Redni broj");
            tablica.AddCell("Broj stavke");
            tablica.AddCell("Broj artikla");
            tablica.AddCell("Naziv");
            tablica.AddCell("Kolicina");
            tablica.AddCell("Iznos");

            int brojac = 0;

            for (int i = 0; i < listaStavke.Count; i++)
            {
                brojac++;
                tablica.AddCell(brojac.ToString());
                tablica.AddCell(listaStavke[i].ID_stavke_racuna.ToString());
                tablica.AddCell(listaStavke[i].ID_artikli.ToString());
                tablica.AddCell(listaStavke[i].Naziv);
                tablica.AddCell(listaStavke[i].Kolicina.ToString());
                tablica.AddCell(listaStavke[i].Iznos.ToString() + " kn");
            }
                 
            tablica.HorizontalAlignment = 1;

            PdfPCell cellUkupno = new PdfPCell(new Phrase("Ukupno:"));
            cellUkupno.Colspan = 5;
            cellUkupno.HorizontalAlignment = 2; // 0 - lijevo 1 - sredina 2 - desno
            tablica.AddCell(cellUkupno);

            tablica.AddCell(lblIznos.Text + " kn");

            doc.Add(tablica);

            Chunk razmak = new Chunk(new VerticalPositionMark());
            PdfPTable ispodTablice = new PdfPTable(1);
            Phrase p = new Phrase();

            p.Add("\n\nPotpis kupca:");
            p.Add(razmak);
            p.Add("Potpis prodavaca:");

            p.Add("\n_____________");
            p.Add(razmak);
            p.Add("_______________");

            ispodTablice.AddCell(p);
            doc.Add(ispodTablice);

            doc.Close();

            stavke = new DBClass.Stavka_racuna();
            stavke.ObrisiSve();

            listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();
            dgvStavkeRacuna.DataSource = listaStavke;

            lblIznos.Text = "0,00";
        }

        private void OcistiRacun_Click_1(object sender, EventArgs e)
        {
            stavke = new DBClass.Stavka_racuna();

            for (int i = 0; i < dgvStavkeRacuna.RowCount; i++)
            {
                int brojArtiklaS = int.Parse(listaStavke[i].ID_artikli.ToString());
                int kolicinaArtiklaS = int.Parse(listaStavke[i].Kolicina.ToString());

                DBClass.Artikl.PovecanjeKolicineSve(brojArtiklaS, kolicinaArtiklaS);
            }

            stavke.ObrisiSve();

            lista = DBClass.Artikl.DohvatiSveArtikle();
            listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();
            dgvPopisArtikla.DataSource = lista;
            dgvStavkeRacuna.DataSource = listaStavke;
            lblIznos.Text = "0,00";
        }
    }
}
