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
            this.artikliTableAdapter.Fill(this._16027_DBDataSet1.Artikli);
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (artikliDataGridView.SelectedRows.Count > 0)
            {
                Artikli odabraniArtikli = artikliDataGridView.SelectedRows[0].DataBoundItem as Artikli;
                AzurirajArtikl openAzuriraj = new AzurirajArtikl(odabraniArtikli);
                openAzuriraj.ShowDialog();
                this.artikliTableAdapter.Fill(this._16027_DBDataSet1.Artikli);
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati artikl?" , "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                artikliDataGridView.Rows.RemoveAt(artikliDataGridView.CurrentRow.Index);

                //if (artikliDataGridView.SelectedRows.Count > 0)
                //{
                //    foreach (DataGridViewRow row in artikliDataGridView.SelectedRows)
                //    {
                //        Artikli odabraniArtikl = row.DataBoundItem as Artikli;
                //        txtBrisanjeArtikla.Text = row.Cells[0].ToString();
                //        odabraniArtikl.Obrisi();
                //    }
                //}
            }
        }

        private void PregledArtikla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet1.Artikli);
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet1.Artikli);
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet1.Artikli);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);
        }
    }
}
