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
    public partial class frmNarudzbenica : Form
    {
        DBClass.Dobavljaci dobavljac;
        DBClass.Narudzbenica narudzbenica;
        DBClass.StavkeNarudzbenice  stavkeNarudzbenice;
        Korisnici korisnik;
      
        
        public frmNarudzbenica()
        {
            dobavljac = new DBClass.Dobavljaci();
            narudzbenica = new DBClass.Narudzbenica();
            stavkeNarudzbenice = new DBClass.StavkeNarudzbenice();
            korisnik = new Korisnici();
            ControlBox = false;
            InitializeComponent();
        }     
        
     

      

        private void btnIzaberiDobavljaca_Click(object sender, EventArgs e)
        {
            
            ListClass.listaDobavljaca.Clear();
            
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmDobavljaci frmDobavljaci = new frmDobavljaci();
            frmDobavljaci.MdiParent = frmDobavljaci.ActiveForm;
            frmDobavljaci.Show();
            
        }

        private void btnUkloniDobavljaca_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati Dobavljača?", "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void btnIzaberiArtikle_Click(object sender, EventArgs e)
        {
            frmNarudzbaArtikli frmArtikl = new frmNarudzbaArtikli();
            frmArtikl.Show();
            this.Close();
        }

        private void frmNarudzbenica_Load(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.DataSource = ListClass.listaDobavljaca;
            dgvArtikli.DataSource = ListClass.listaArtikla;

           
            
            
        }

        private void btnUkloniArtikl_Click(object sender, EventArgs e)
        {
            dgvArtikli.Rows.RemoveAt(dgvArtikli.SelectedCells[0].RowIndex);
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna frmHome = new frmCvjecarna();
            frmHome.Show();
            this.Close();
        }

        private void btnIzradiNarudzbenicu_Click(object sender, EventArgs e)
        {
            DateTime datumNarudzbe = DateTime.Now;
            //punjenje clase Narudzbenica
            korisnik.AktivanKorisnik();
            dobavljac.DohvatiDobavljace(ListClass.iDDovacljaca);
            narudzbenica.ID_dobavljac = ListClass.iDDovacljaca;
            narudzbenica.ID_korisnici = korisnik.ID_korisnik;
            narudzbenica.Datum_vrijeme = datumNarudzbe;
           
           
            
                
               

                
                
                
                   
                    narudzbenica.Spremi();
                    narudzbenica.DohvatiIDNaruzbe();
                    //punjenje clase stavke_narudzbenice

                    stavkeNarudzbenice.ID_narudzbenice = narudzbenica.ID_narudzbenica;
                    foreach (DataGridViewRow s in dgvArtikli.Rows)
                    {
                        int iDArtikla = 0;
                        try
                        {
                            if (int.TryParse(s.Cells["ID_artikla"].Value.ToString(), out iDArtikla))
                            {
                                stavkeNarudzbenice.ID_artikla = iDArtikla;
                                stavkeNarudzbenice.Insert();
                            }
                        }
                        catch { }

                    
                    MessageBox.Show("Narudžbenica je uspješno kreirana!");
                    
                
            }
        }
       










    }
}
