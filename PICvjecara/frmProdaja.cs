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

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Racun'" + lblBrRacuna.Text + "'.pdf", FileMode.Create));
            doc.Open();

            var naslovFont = FontFactory.GetFont("Arial", 20, BaseColor.BLACK);
            var tablicaFont = FontFactory.GetFont("Arial", 12, BaseColor.BLACK);
            var textFont = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);

            Paragraph firma = new Paragraph("Cvjecarna Mak d.o.o.", textFont);
            Paragraph ulica = new Paragraph("Koprivnicka 7", textFont);
            Paragraph grad = new Paragraph("Varazdin", textFont);
            Paragraph oib = new Paragraph("2873467382912", textFont);

            Paragraph crta = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

            iTextSharp.text.Image slika = iTextSharp.text.Image.GetInstance("C:/Users/vibor/Documents/GitHub/r16027/PICvjecara/Slike/logo.png");
            slika.ScalePercent(25f);
            slika.Alignment = 2;
            slika.SetAbsolutePosition(500, 690);

            doc.Add(firma);
            doc.Add(slika);
            doc.Add(ulica);
            doc.Add(grad);
            doc.Add(oib);
            doc.Add(crta);            

            Paragraph ime = new Paragraph("\n\nIme izdavaca: " + korisnik.Ime, textFont);
            ime.Alignment = 2;
            Paragraph prezime = new Paragraph("Prezime izdavaca: " + korisnik.Prezime, textFont);
            prezime.Alignment = 2;
            Paragraph datum = new Paragraph("Datum: " + listaStavke[0].Datum.ToString(), textFont);
            datum.Alignment = 2;
            Paragraph placanje = new Paragraph("Način placanja: " + "Gotovina", textFont);
            placanje.Alignment = 2;

            doc.Add(ime);
            doc.Add(prezime);
            doc.Add(datum);
            doc.Add(placanje);

            Paragraph paragraph = new Paragraph("\n\nRacun br: " + broj, naslovFont);
            paragraph.Alignment = 1;
            paragraph.Font.SetStyle("bold");

            doc.Add(paragraph);

            Paragraph noviRed = new Paragraph("\n\n");
            doc.Add(noviRed);

            PdfPTable tablica = new PdfPTable(7);

            tablica.DefaultCell.HorizontalAlignment = 1;
            tablica.AddCell(new Phrase("Redni broj", tablicaFont));
            tablica.AddCell(new Phrase("Broj stavke", tablicaFont));
            tablica.AddCell(new Phrase("Broj artikla", tablicaFont));
            tablica.AddCell(new Phrase("Naziv", tablicaFont));
            tablica.AddCell(new Phrase("Kolicina", tablicaFont));
            tablica.AddCell(new Phrase("PDV", tablicaFont));
            tablica.AddCell(new Phrase("Iznos", tablicaFont));   
                     
            int brojac = 0;
            double pdv = 0;

            for (int i = 0; i < listaStavke.Count; i++)
            {
                brojac++;
                PdfPCell cell1 = new PdfPCell(new Phrase(brojac.ToString(), textFont));
                cell1.HorizontalAlignment = 2;
                PdfPCell cell2 = new PdfPCell(new Phrase(listaStavke[i].ID_stavke_racuna.ToString(), textFont));
                cell2.HorizontalAlignment = 1;
                PdfPCell cell3 = new PdfPCell(new Phrase(listaStavke[i].ID_artikli.ToString(), textFont));
                cell3.HorizontalAlignment = 1;
                PdfPCell cell4 = new PdfPCell(new Phrase(listaStavke[i].Naziv, textFont));
                cell4.HorizontalAlignment = 0;
                PdfPCell cell5 = new PdfPCell(new Phrase(listaStavke[i].Kolicina.ToString(), textFont));
                cell5.HorizontalAlignment = 2;
                PdfPCell cell6 = new PdfPCell(new Phrase("25%", textFont));
                cell6.HorizontalAlignment = 1;
                PdfPCell cell7 = new PdfPCell(new Phrase(listaStavke[i].Iznos.ToString() + " kn", textFont));
                cell7.HorizontalAlignment = 2;

                tablica.AddCell(cell1);
                tablica.AddCell(cell2);
                tablica.AddCell(cell3);
                tablica.AddCell(cell4);
                tablica.AddCell(cell5);
                tablica.AddCell(cell6);
                tablica.AddCell(cell7);

                pdv = pdv + (int.Parse(listaStavke[i].Iznos.ToString())*0.25);
            }            

            tablica.HorizontalAlignment = 1;            

            PdfPCell cellPDV = new PdfPCell(new Phrase("PDV:"));
            cellPDV.Colspan = 6;
            cellPDV.HorizontalAlignment = 2; 
            tablica.AddCell(cellPDV);

            tablica.AddCell(pdv.ToString() + " kn");

            PdfPCell cellUkupno = new PdfPCell(new Phrase("Ukupno:"));
            cellUkupno.Colspan = 6;
            cellUkupno.HorizontalAlignment = 2; 
            tablica.AddCell(cellUkupno);

            tablica.AddCell((int.Parse(lblIznos.Text) + pdv).ToString() + " kn");

            doc.Add(tablica);

            Chunk razmak = new Chunk(new VerticalPositionMark());
            PdfPTable ispodTablice = new PdfPTable(3);

            PdfPCell potpisP = new PdfPCell(new Phrase("\n\n\n\nPotpis prodavaca:"));
            potpisP.Border = 0;


            PdfPCell potpisK = new PdfPCell(new Phrase("\n\n\n\nPotpis kupca:"));
            potpisK.Border = 0;
            potpisK.Colspan = 2;
            potpisK.HorizontalAlignment = 2;

            PdfPCell crta1 = new PdfPCell(new Phrase("\n_______________"));
            crta1.Border = 0;
            
            PdfPCell crta2 = new PdfPCell(new Phrase("\n____________"));
            crta2.Border = 0;
            crta2.Colspan = 2;
            crta2.HorizontalAlignment = 2;

            ispodTablice.AddCell(potpisP);
            ispodTablice.AddCell(potpisK);
            ispodTablice.AddCell(crta1);
            ispodTablice.AddCell(crta2);

            

            doc.Add(ispodTablice);

            doc.Close();

            stavke.ObrisiSve();

            listaStavke = DBClass.Stavka_racuna.DohvatiSveStavke();
            dgvStavkeRacuna.DataSource = listaStavke;

            lblIznos.Text = "0,00";

            MessageBox.Show("Račun uspiješno kreiran");
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
