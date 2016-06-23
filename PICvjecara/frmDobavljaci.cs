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
    public partial class frmDobavljaci : Form
    {

        GridLoad.GridLoad grid = new GridLoad.GridLoad(DatabaseConnection.Instance.ConnectionString);
        



        public frmDobavljaci()
        {
            ControlBox = false;
            
            InitializeComponent();
        }

        private void frmDobavljaci_Load(object sender, EventArgs e)
        {
            dataGridView1.Update();
            
            dataGridView1.DataSource = grid.GridDataLoad(SqlCommandsGrid.qDobavljaci);
            
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DBClass.Dobavljac dobavljac = new DBClass.Dobavljac();
                int odabrani = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                dobavljac.DohvatiDobavljace(odabrani);
                ListClass.iDDovacljaca = odabrani;

                ListClass.listaDobavljaca = dobavljac.ListaDobavljaca(dobavljac);
                if (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();
                }
                frmNarudzbenica frmNar = new frmNarudzbenica();
                frmNar.MdiParent = frmNarudzbenica.ActiveForm;
                frmNar.Show();
                
            }
            else
            {
                MessageBox.Show("Niste odabrali dobavljača!");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmDodajDobavljaca frmDodaj = new frmDodajDobavljaca();
            frmDodaj.MdiParent = frmDodajDobavljaca.ActiveForm;
            frmDodaj.Show();
            
        }

    }
}
