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
        public int odabir;
        GridLoad.GridLoad gridLoad = new GridLoad.GridLoad(DatabaseConnection.Instance.ConnectionString);
        DBClass.Rezervacija rezervacija;
        DBClass.Stavka_rezervacije stavkeRezervacije;
        DBClass.Nalog_za_prodaju nalogZaProdaju;

        public frmPregledRezervacija()
        {
            rezervacija = new DBClass.Rezervacija();
            stavkeRezervacije = new DBClass.Stavka_rezervacije();
            nalogZaProdaju = new DBClass.Nalog_za_prodaju();
            ControlBox = false;
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
                int odabirRezervacije = int.Parse(dgvRezervacija.SelectedCells[0].Value.ToString());



                odabir = odabirRezervacije;

            }
            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            frmRezervacijePDF frmPregledRez = new frmRezervacijePDF(odabir);
            frmPregledRez.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRezervacija.SelectedRows.Count > 0)
            {
                int odabirRezervacije = int.Parse(dgvRezervacija.SelectedCells[0].Value.ToString());
                nalogZaProdaju.Brisi(odabirRezervacije);
                stavkeRezervacije.Brisi(odabirRezervacije);
                rezervacija.Brisi(odabirRezervacije);
                dgvRezervacija.Rows.RemoveAt(dgvRezervacija.CurrentRow.Index);




            }

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            frmSendEmail frmMail = new frmSendEmail();
            frmMail.Show();
        }
    }
}
