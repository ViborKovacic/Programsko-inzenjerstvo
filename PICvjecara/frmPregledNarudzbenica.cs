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
    public partial class frmPregledNarudzbenica : Form
    {
        GridLoad.GridLoad gridLoad = new GridLoad.GridLoad(DatabaseConnection.Instance.ConnectionString);
        DBClass.Narudzbenica narudzbenica;
        DBClass.StavkeNarudzbenice stavkeNarudzbenice;
        public int odabir;
        public frmPregledNarudzbenica()
        {
            narudzbenica = new DBClass.Narudzbenica();
            stavkeNarudzbenice = new DBClass.StavkeNarudzbenice();
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna frmHome = new frmCvjecarna();
            frmHome.Show();
            this.Close();
        }

        private void frmPregledNarudzbenica_Load(object sender, EventArgs e)
        {
            dgvNazivNarudzbenica.DataSource = gridLoad.GridDataLoad(SqlCommandsGrid.qNarudzbe);
            
        }

        private void dgvNazivNarudzbenica_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNazivNarudzbenica.SelectedRows.Count > 0)
            {
                int odabirNarudzbe = int.Parse(dgvNazivNarudzbenica.SelectedCells[0].Value.ToString());



                string qNarudzbeArtikli = "select a.Naziv as 'Naziv artikla', a.Cijena as 'Pojedinačna cijena' from Artikli a, Stavke_narudzbenice sn where sn.ID_artikla = a.ID_artikla and  sn.ID_narudzbenice=" + odabirNarudzbe;
                
                dgvArtikli.DataSource = gridLoad.GridDataLoad(qNarudzbeArtikli);
                odabir = odabirNarudzbe;
                
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvNazivNarudzbenica.SelectedRows.Count > 0)
            {
                int odabirNarudzbe = int.Parse(dgvNazivNarudzbenica.SelectedCells[0].Value.ToString());
                narudzbenica.Brisi(odabirNarudzbe);
                stavkeNarudzbenice.Brisi(odabirNarudzbe);
                int indexNazivaNar = dgvNazivNarudzbenica.CurrentRow.Index;
                dgvNazivNarudzbenica.Rows.RemoveAt(dgvNazivNarudzbenica.CurrentRow.Index);
                

                
            }
            
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

            frmPDF frmPdf = new frmPDF(odabir);
            frmPdf.Show();
            this.Close();
        }
    }
}
