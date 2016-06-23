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
        DBClass.Kupac klijent;
        public frmKlijenti()
        {
            ControlBox = false;
           
            InitializeComponent();
        }

        private void frmKlijenti_Load(object sender, EventArgs e)
        {
            dgvKlijent.DataSource = gridLoad.GridDataLoad(SqlCommandsGrid.qKlijenti);
            

        }

        

       

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvKlijent.SelectedRows.Count > 0)
            {
                klijent = new DBClass.Kupac();

                int odabrani = int.Parse(dgvKlijent.SelectedCells[0].Value.ToString());
                klijent.DohvatiKlijenta(odabrani);
                
                frmAzurirajKlijenta frmAzurirajKlijenta = new frmAzurirajKlijenta(klijent);
                frmAzurirajKlijenta.MdiParent = frmDodajKlijenta.ActiveForm;
                frmAzurirajKlijenta.Show();
               


            }
            else
            {
                MessageBox.Show("Niste odabrali Klijenta!");
            }
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmDodajKlijenta frmDodajKlijenta = new frmDodajKlijenta();
            frmDodajKlijenta.MdiParent = frmDodajKlijenta.ActiveForm;
            frmDodajKlijenta.Show();
            
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
               klijent = new DBClass.Kupac();
                ulong broj = 0;
                if (ulong.TryParse(txtTrazi.Text, out broj))
                {
                klijent.OIB = txtTrazi.Text;
                klijent.DohvatiIzBazeOIB();
                if (klijent.broj > 0)
                {
                    if (ActiveMdiChild != null)
                    {
                        ActiveMdiChild.Close();
                    }
                    frmAzurirajKlijenta frmAzurajKlijenta = new frmAzurirajKlijenta(klijent);
                    frmAzurajKlijenta.MdiParent = frmAzurirajKlijenta.ActiveForm;
                    frmAzurajKlijenta.Show();
                    

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
                DBClass.Kupac klijent = new DBClass.Kupac();
                int odabrani = int.Parse(dgvKlijent.SelectedCells[0].Value.ToString());
                klijent.DohvatiKlijenta(odabrani);
                ListClass.iDKlijenta = odabrani;

                ListClass.listaKlijenta = klijent.ListaKlijenta(klijent);
                if (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();
                }
                frmRezervacija frmRez = new frmRezervacija();
                frmRez.MdiParent = frmRezervacija.ActiveForm;
                frmRez.Show();
             
            }
            else
            {
                MessageBox.Show("Niste odabrali Klijenta!");
            }
        }
    }
}
