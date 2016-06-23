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
    public partial class frmDodajKlijenta : Form
    {
        DBClass.Kupac klijent;
        public frmDodajKlijenta()
        {
            ControlBox = false;
            InitializeComponent();
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            klijent = new DBClass.Kupac();
            if (txtIme.Text == "" && txtprezime.Text == "" && txtOIB.Text == "")
            {
                MessageBox.Show("Nisu uneseni svi potrebni podaci!");
            }
            else
            {
                ulong broj = 0;
                if (ulong.TryParse(txtOIB.Text, out broj))
                {
                    klijent.Ime = txtIme.Text;
                    klijent.Prezime = txtprezime.Text;
                    klijent.OIB = txtOIB.Text;
                    klijent.Adresa = txtAdresa.Text;
                    klijent.Email = txtEmail.Text;
                    klijent.Telefon = txtTelefon.Text;
                    klijent.Insert();
                    MessageBox.Show("Klijent je unesen u bazu!");

                }
                else
                {
                    MessageBox.Show("Krivo unesen OIB Klijenta!");
                }
            }

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmKlijenti frmKlijent = new frmKlijenti();
            frmKlijent.MdiParent = frmKlijenti.ActiveForm;
            frmKlijent.Show();
          
        }

        private void frmDodajKlijenta_Load(object sender, EventArgs e)
        {

        }
    }
}
