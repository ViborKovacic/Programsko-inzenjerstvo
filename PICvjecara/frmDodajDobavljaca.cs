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
        DBClass.Dobavljaci dobavljac;
        public frmDodajDobavljaca()
        {
            dobavljac = new DBClass.Dobavljaci();
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmDobavljaci frmDob = new frmDobavljaci();
            frmDob.Show();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UInt64 OIB = 0;
            string uneseniOIB = txtOIB.Text;
            if (ulong.TryParse(uneseniOIB, out OIB))
            {
                dobavljac.Ime = txtIme.Text;
                dobavljac.OIB = txtOIB.Text;
                dobavljac.Adresa = txtAdresa.Text;
                dobavljac.Telefon = txtTelefon.Text;
                dobavljac.DodajDobavljaca();
            }
            else
            {
                MessageBox.Show("Krivo unesen OIB!");
            }
        }
    }
}
