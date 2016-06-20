using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PICvjecara
{
    public partial class frmNarudzbaArtikli : Form
    {
        GridLoad.GridLoad grid = new GridLoad.GridLoad(DatabaseConnection.Instance.ConnectionString);
        DBClass.Artikli artikl;
        public BindingList<DBClass.Artikli> listaArtikla;
        private bool provjera = false;
        public frmNarudzbaArtikli()
        {

            listaArtikla = new BindingList<DBClass.Artikli>();
            InitializeComponent();
        }

        private void frmNarudzbaArtikli_Load(object sender, EventArgs e)
        {
            dgvVrstaArtikla.DataSource = grid.GridDataLoad(SqlCommandsGrid.qVrstaArtikla);
            dgvOdabraniArtikli.DataSource = ListClass.listaArtikla;
            if (ListClass.listaArtikla.Count == 0)
            {
                btnBrisi.Enabled = false;
            }
        }

        private void dgvVrstaArtikla_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvVrstaArtikla.SelectedRows.Count > 0)
            {
                int odabriArtikla = int.Parse(dgvVrstaArtikla.SelectedCells[0].Value.ToString());
                string qArtikli = "select a.ID_artikla as 'Broj artikla',a.Naziv as 'Naziv artikla',a.Cijena as 'Cijena' from Artikli a, Vrsta_artikla va where va.ID_vrsta_artikla =a.ID_vrsta_artikla and va.ID_vrsta_artikla =" + odabriArtikla;

                dgvArtikli.DataSource = grid.GridDataLoad(qArtikli);
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            if (provjera)
            {
                ListClass.listaArtikla = listaArtikla;
            }
            frmNarudzbenica frmDobavljac = new frmNarudzbenica();
            frmDobavljac.Show();
            this.Close();
        }

        private void btnOdaberiArtikl_Click(object sender, EventArgs e)
        {
            if (dgvVrstaArtikla.SelectedRows.Count > 0 && dgvArtikli.SelectedRows.Count > 0)
            {
                artikl = new DBClass.Artikli();
                int odabriArtikla = int.Parse(dgvArtikli.SelectedCells[0].Value.ToString());
                artikl.DohvatiArtikl(odabriArtikla);
                listaArtikla = artikl.DohvatiListu(artikl);
                dgvOdabraniArtikli.DataSource = listaArtikla;
                btnBrisi.Enabled = true;
                provjera = true;
                

            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            
            dgvOdabraniArtikli.Rows.RemoveAt(dgvOdabraniArtikli.SelectedCells[0].RowIndex);
            
        }
    }
}
