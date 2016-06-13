using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace PICvjecara
{
    public partial class frmRezervacije : Form
    {
        DBClass.Tip_rezervacije VrstaRezervacije;
        DBClass.Rezervacija Rezervacija;
        DBClass.Stavke_rezervacije StavkeRezervacije;
        public frmRezervacije()
        {
            VrstaRezervacije = new DBClass.Tip_rezervacije();
            Rezervacija = new DBClass.Rezervacija();
            StavkeRezervacije = new DBClass.Stavke_rezervacije();
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna frmHome = new frmCvjecarna();
            frmHome.Show();
            this.Close();
        }
        #region Metode Za Combobox
        /// <summary>
        /// Ovdje se nalaze metode za punjenje comboboxeva i ostalih operacija vezanjih uz njih
        /// </summary>
        private void DohvatiVrsteRezervacije()
        {
            cmbVrstaRezervacije.Items.Clear();
            string q = "select * from Tip_rezervacije";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while(dr.Read())
            {
                cmbVrstaRezervacije.Items.Add(dr["Vrsta"].ToString());
            }
            dr.Close();


        }
        

        private void cmbVrstaRezervacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            VrstaRezervacije.Vrsta = cmbVrstaRezervacije.GetItemText(cmbVrstaRezervacije.SelectedItem.ToString());
            VrstaRezervacije.DohvatiIzBaze();

            Rezervacija.ID_tip_rezervacije = VrstaRezervacije.ID_tip_rezervacije;
            Rezervacija.DohvatiIzBaze();
            txtCijenaRezervacije.Text = Rezervacija.Cijena.ToString();
            txtOpisRezervacije.Text = Rezervacija.Opis.ToString();

        }
        #endregion

        private void frmRezervacije_Load(object sender, EventArgs e)
        {
            DohvatiVrsteRezervacije();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            int kolicina = int.Parse(txtKolicinaRezervacije.Text);
            
            frmRezerviranjeKorisnici frmRezKor = new frmRezerviranjeKorisnici(kolicina);
            frmRezKor.Show();
            this.Close();
        }

        private void btnUpravljanjeRezer_Click(object sender, EventArgs e)
        {
            frmRezervacijeADD frmRez = new frmRezervacijeADD();
            frmRez.Show();
            this.Close();
        }
    }
}
