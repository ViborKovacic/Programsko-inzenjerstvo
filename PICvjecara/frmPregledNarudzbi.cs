using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace PICvjecara
{
    public partial class frmPregledNarudzbi : Form
    {
        DBClass.StavkeNarudzbenice stavkeNarudzbe;
        DBClass.Narudzbenica narudzbenica;
    

        public frmPregledNarudzbi()
        {
            stavkeNarudzbe = new DBClass.StavkeNarudzbenice();
            narudzbenica = new DBClass.Narudzbenica();
            InitializeComponent();
            
        }

        private void frmPregledNarudzbi_Load(object sender, EventArgs e)
        {
            string q = "select n.ID_narudzbenice as 'Broj Narudžbe',va.Vrsta as 'Vrsta Artikla',a.Naziv as 'Naziv Artikla',d.Ime as 'Dobavljač', n.datum_vrijeme as 'Datum Narudžbe',k.ime as 'korisnik', n.kolicina as 'Naručena Količina' from Narudzbenica n , Dobavljaci d, Korisnici k, Stavke_narudzbenice sn, Artikli a , Vrsta_artikla va where d.ID_dobavljac=n.ID_dobavljac and n.ID_korisnici=k.ID_korisnik and  n.ID_narudzbenice=sn.ID_narudzbenice and a.ID_artikla = sn.ID_artikla and a.ID_vrsta_artikla = va.ID_vrsta_artikla";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            DataTable dtDetalji = new DataTable();
            dataGridView1.DataSource = null;
            dtDetalji.Load(dr);
            dr.Close();
            dataGridView1.DataSource = dtDetalji;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna home = new frmCvjecarna();
            home.Show();
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati narudžu?", "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int odabirNarudzbe = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                    
                    stavkeNarudzbe.Brisi(odabirNarudzbe);
                    narudzbenica.Brisi(odabirNarudzbe);

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    

                }
            }
        }
    }
}
