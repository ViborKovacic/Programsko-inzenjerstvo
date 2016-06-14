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
using GridLoad;

namespace PICvjecara
{
    public partial class frmPregledNarudzbi : Form
    {
        DBClass.StavkeNarudzbenice stavkeNarudzbe;
        DBClass.Narudzbenica narudzbenica;
        GridLoad.GridLoad gridDataLoad;
        
    

        public frmPregledNarudzbi()
        {
            stavkeNarudzbe = new DBClass.StavkeNarudzbenice();
            narudzbenica = new DBClass.Narudzbenica();
            gridDataLoad = new GridLoad.GridLoad();
            InitializeComponent();
            
        }

        private void frmPregledNarudzbi_Load(object sender, EventArgs e)
        {
            
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gridDataLoad.GridLoadData(SqlCommandsGrid.qNarudzbe);
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
