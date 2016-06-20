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
    public partial class frmKlijenti : Form
    {
        GridLoad.GridLoad gridLoad = new GridLoad.GridLoad(DatabaseConnection.Instance.ConnectionString);
        DBClass.Kupci klijent;
        public frmKlijenti()
        {
           
            InitializeComponent();
        }

        private void frmKlijenti_Load(object sender, EventArgs e)
        {
            dgvKlijent.DataSource = gridLoad.GridDataLoad(SqlCommandsGrid.qKlijenti);
            

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna frmHome = new frmCvjecarna();
            frmHome.Show();
            this.Close();
        }

       

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvKlijent.SelectedRows.Count > 0)
            {
                klijent = new DBClass.Kupci();

                int odabrani = int.Parse(dgvKlijent.SelectedCells[0].Value.ToString());
                klijent.DohvatiKlijenta(odabrani);
                
                frmAzurirajKlijenta frmAzurirajKlijenta = new frmAzurirajKlijenta(klijent);
                frmAzurirajKlijenta.Show();
                this.Close();



            }
            else
            {
                MessageBox.Show("Niste odabrali Klijenta!");
            }
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            frmDodajKlijenta frmDodajKlijenta = new frmDodajKlijenta();
            frmDodajKlijenta.Show();
            this.Close();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
               klijent = new DBClass.Kupci();
                ulong broj = 0;
                if (ulong.TryParse(txtTrazi.Text, out broj))
                {
                klijent.OIB = txtTrazi.Text;
                klijent.DohvatiIzBazeOIB();
                if (klijent.broj > 0)
                {
                    frmAzurirajKlijenta frmAzurajKlijenta = new frmAzurirajKlijenta(klijent);
                    frmAzurajKlijenta.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Klijent ne postoji u bazi!");
                }

                   

                }
                else
                {
                    MessageBox.Show("Krivo unesen OIB Klijenta!");
                }
            }

        private void btnOdabirKlijenta_Click(object sender, EventArgs e)
        {

            if (dgvKlijent.SelectedRows.Count > 0)
            {
                DBClass.Kupci klijent = new DBClass.Kupci();
                int odabrani = int.Parse(dgvKlijent.SelectedCells[0].Value.ToString());
                klijent.DohvatiKlijenta(odabrani);
                ListClass.iDKlijenta = odabrani;

                ListClass.listaKlijenta = klijent.ListaKlijenta(klijent);
                frmRezervacija frmRez = new frmRezervacija();
                frmRez.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Niste odabrali Klijenta!");
            }
        }
    }
}
