using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICvjecara
{
    public partial class frmDodajDobavljaca : Form
    {
        DBClass.Dobavljac dobavljac;
        public frmDodajDobavljaca()
        {
            dobavljac = new DBClass.Dobavljac();
            ControlBox = false;
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmDobavljaci frmDobavljac = new frmDobavljaci();
            frmDobavljac.MdiParent = frmDobavljaci.ActiveForm;
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UInt64 OIB = 0;
            UInt64 Telefon = 0;
            string uneseniOIB = txtOIB.Text;
            string uneseniTelefon = txtTelefon.Text;
            if (ulong.TryParse(uneseniOIB, out OIB)&&ulong.TryParse(uneseniTelefon,out Telefon))
            {
                dobavljac.Ime = txtIme.Text;
                dobavljac.OIB = txtOIB.Text;
                dobavljac.Adresa = txtAdresa.Text;
                dobavljac.Telefon = txtTelefon.Text;
                dobavljac.DodajDobavljaca();
                MessageBox.Show("Dobavljač je kreiran!");
            }
            else
            {
                MessageBox.Show("Krivo unesen OIB ili broj telefona");
            }
            
        }

        private void frmDodajDobavljaca_Load(object sender, EventArgs e)
        {

        }
    }
}
