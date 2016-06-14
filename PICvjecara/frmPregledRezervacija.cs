using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridLoad;

namespace PICvjecara
{
    public partial class frmPregledRezervacija : Form
    {
        GridLoad.GridLoad gridLoadData;
        DBClass.Nalog_za_prodaju NalogZaProdaju;
        DBClass.Stavke_rezervacije StavkeRezervacije;

        public frmPregledRezervacija()
        {
            gridLoadData = new GridLoad.GridLoad();
            NalogZaProdaju = new DBClass.Nalog_za_prodaju();
            StavkeRezervacije = new DBClass.Stavke_rezervacije();
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna frmHome = new frmCvjecarna();
            frmHome.Show();
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati narudžu?", "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int odabirRez = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());

                    NalogZaProdaju.Brisi(odabirRez);
                    NalogZaProdaju.Brisi(odabirRez);
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);


                }
            }
        }

        private void frmPregledRezervacija_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gridLoadData.GridLoadData(SqlCommandsGrid.qRezervacije);
        }
    }
}
