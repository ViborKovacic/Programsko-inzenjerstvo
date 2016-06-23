using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridLoad;

namespace PICvjecara
{
    public partial class frmRezervacija : Form
    {
        GridLoad.GridLoad gridLoad = new GridLoad.GridLoad(DatabaseConnection.Instance.ConnectionString);
        DBClass.Rezervacija rezervacija;
        DBClass.Stavka_rezervacije stavkeRezervacije;
        DBClass.Tip_rezervacije vrstaArtikla;
        DBClass.Nalog_za_prodaju nalogZaProdaju;
        Korisnici korisnik = new Korisnici();

        public frmRezervacija()
        {
            vrstaArtikla = new DBClass.Tip_rezervacije();
            rezervacija = new DBClass.Rezervacija();
            stavkeRezervacije = new DBClass.Stavka_rezervacije();
            nalogZaProdaju = new DBClass.Nalog_za_prodaju();
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna frmHome = new frmCvjecarna();
            frmHome.Show();
            this.Close();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmDodajVrstuRezervacije frmDodajRez = new frmDodajVrstuRezervacije();
            frmDodajRez.MdiParent = frmDodajVrstuRezervacije.ActiveForm;
            frmDodajRez.Show();

        }

        private void frmRezervacija_Load(object sender, EventArgs e)
        {
            dgvVrstaRezervacije.DataSource = gridLoad.GridDataLoad(SqlCommandsGrid.qVrstaRezervacije);
            dgvKlijent.DataSource = ListClass.listaKlijenta;
        }

        private void brnOdaberiKlijenta_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmKlijenti frmKlijent = new frmKlijenti();
            frmKlijent.MdiParent = frmKlijenti.ActiveForm;
            frmKlijent.Show();
            
        }

        private void btnRezerviraj_Click_1(object sender, EventArgs e)
        {
            DateTime datumrezervacije = DateTime.Now;
            
            if (dgvVrstaRezervacije.SelectedRows.Count > 0)
            {
                int odabrani = int.Parse(dgvVrstaRezervacije.SelectedCells[0].Value.ToString());

                rezervacija.Opis = txtOpis.Text;
                rezervacija.Cijena = float.Parse(txtOkvirnaCijena.Text);
                rezervacija.ID_tip_rezervacije = odabrani;
                rezervacija.Insert();
                rezervacija.DohvatiIDRezervacije();

                nalogZaProdaju.ID_kupci = ListClass.iDKlijenta;
                nalogZaProdaju.ID_korisnik = korisnik.ID_korisnik;
                nalogZaProdaju.Datum = datumrezervacije;
                nalogZaProdaju.Insert();
                nalogZaProdaju.DohvatiIdNaloga();

                stavkeRezervacije.ID_nalog_za_prodaju = nalogZaProdaju.ID_nalog_za_prodaju;
                stavkeRezervacije.ID_rezervacija = rezervacija.ID_rezervacije;
                stavkeRezervacije.Datum_izrade = datumrezervacije;
                stavkeRezervacije.Datum_izvrsavanja = dTimer.Value.Date;
                stavkeRezervacije.Insert();
                MessageBox.Show("Rezervacija je uspješno kreirana!");


            }
            else
            {
                MessageBox.Show("Niste odabrali vrstu rezervacije!");
            }
        }
    }
}
