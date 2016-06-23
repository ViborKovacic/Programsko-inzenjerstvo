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
    public partial class frmAzurirajKlijenta : Form
    {
        DBClass.Kupac klijent;
        public frmAzurirajKlijenta(DBClass.Kupac Kupac)
        {
            klijent = new DBClass.Kupac();
            klijent = Kupac;
            InitializeComponent();
        }

        private void frmAzurirajKlijenta_Load(object sender, EventArgs e)
        {
           
            txtIme.Text = klijent.Ime;
            txtprezime.Text = klijent.Prezime;
            txtAdresa.Text = klijent.Adresa;
            txtEmail.Text = klijent.Email;
            txtTelefon.Text = klijent.Telefon;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            uint broj = 0;
            if (uint.TryParse(txtTelefon.Text, out broj))

            {
                klijent.Ime = txtIme.Text;
                klijent.Prezime = txtprezime.Text;
                klijent.Adresa = txtAdresa.Text;
                klijent.Email = txtEmail.Text;
                klijent.Telefon = txtTelefon.Text;
                klijent.Update();
                MessageBox.Show("Klijent je ažuriran!");
            }
            else
            {
                MessageBox.Show("Krivo unesen telefonski broj");
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
    }
}
