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
          
            
            InitializeComponent();
        }

        private void frmDobavljaci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = grid.GridDataLoad(SqlCommandsGrid.qDobavljaci);
            
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DBClass.Dobavljaci dobavljac = new DBClass.Dobavljaci();
                int odabrani = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                dobavljac.DohvatiDobavljace(odabrani);
                ListClass.iDDovacljaca = odabrani;

                ListClass.listaDobavljaca = dobavljac.ListaDobavljaca(dobavljac);
                frmNarudzbenica frm = new frmNarudzbenica();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Niste odabrali dobavljača!");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajDobavljaca frmDodaj = new frmDodajDobavljaca();
            frmDodaj.Show();
            this.Close();
        }

        private void btnPovarakta_Click(object sender, EventArgs e)
        {
            frmNarudzbenica frmNar = new frmNarudzbenica();
            frmNar.Show();
            this.Close();
        }
    }
}
