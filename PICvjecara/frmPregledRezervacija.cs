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
    public partial class frmPregledRezervacija : Form
    {
        GridLoad.GridLoad gridLoad = new GridLoad.GridLoad(DatabaseConnection.Instance.ConnectionString);
        DBClass.Rezervacija rezervacija;
        public frmPregledRezervacija()
        {
            rezervacija = new DBClass.Rezervacija();
            InitializeComponent();
        }

        private void frmPregledRezervacija_Load(object sender, EventArgs e)
        {
            dgvRezervacija.DataSource = gridLoad.GridDataLoad(SqlCommandsGrid.qPrikazRezervacije);
        }

        private void dgvRezervacija_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRezervacija.SelectedRows.Count > 0)
            {
                int odabir = int.Parse(dgvRezervacija.SelectedCells[0].Value.ToString());
                string qPrikazDetaljaRezervacije = "select k.Ime as 'Ime klijenta',k.OIB as 'OIB Klijenta',vr.Vrsta as 'Vrsta usluge',r.Cijena as 'Okvirna cijena', ko.Ime as 'Izradio', nzp.Datum as'Datum Izrade' from Kupci k, Korisnici ko, Nalog_za_prodaju nzp, Stavke_rezervacije sr, Rezervacija r, Tip_rezervacije vr where r.ID_rezervacije ="+odabir+" and r.ID_tip_rezervacije=vr.ID_tip_rezervacije and sr.ID_rezervacija="+odabir+" and sr.ID_nalog_za_prodaju = nzp.ID_nalog_za_prodaju and nzp.ID_korisnik=ko.ID_korisnik and nzp.ID_kupci = k.ID_kupca";
                
                dgvRezervacijeDetalji.DataSource = gridLoad.GridDataLoad(qPrikazDetaljaRezervacije);
                rezervacija.DohvatiIzBaze(odabir);
                txtOpis.Text = rezervacija.Opis;
            }
            
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna frmHome = new frmCvjecarna();
            frmHome.Show();
            this.Close();
        }
    }
}
