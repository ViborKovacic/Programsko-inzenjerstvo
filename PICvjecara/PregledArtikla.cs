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

namespace PICvjecara
{
    public partial class PregledArtikla : Form
    {
        public PregledArtikla()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna openCvjecarna = new frmCvjecarna();
            openCvjecarna.Show();
            this.Close();
        }

        private void btnUnosNovogArtikla_Click(object sender, EventArgs e)
        {
            UnosArtikla openUnosArtikla = new UnosArtikla();
            openUnosArtikla.ShowDialog();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (artikliDataGridView.SelectedRows.Count > 0)
            {
                Artikli odabraniArtikli = artikliDataGridView.SelectedRows[0].DataBoundItem as Artikli;
                AzurirajArtikl openAzuriraj = new AzurirajArtikl(odabraniArtikli);
                openAzuriraj.ShowDialog();
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            Artikli artikli = new Artikli();
            int obrisiArikl = 0;

            if (MessageBox.Show("Želite li obrisati artikl?" , "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (artikliDataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = artikliDataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];
                    obrisiArikl = int.Parse(selectedRow.Cells["ID_artikla"].Value.ToString());
                }

                artikliDataGridView.Rows.RemoveAt(artikliDataGridView.CurrentRow.Index);   
                artikli.Obrisi(obrisiArikl);
            }
        }

        private void artikliDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (artikliDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = artikliDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];
                txtBrisanjeArtikla.Text = Convert.ToString(selectedRow.Cells["ID_artikla"].Value);
            }
        }

        private void PregledArtikla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet1.Artikli);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);
        }
    }
}
