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
        public void IspisArtikla()
        {
            List<Artikli> listaArtikla = Artikli.DohvatiArtikle();
            dataGridView1.DataSource = listaArtikla;
        }

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
            IspisArtikla();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Artikli odabraniArtikli = dataGridView1.SelectedRows[0].DataBoundItem as Artikli;
                AzurirajArtikl openAzuriraj = new AzurirajArtikl(odabraniArtikli);
                openAzuriraj.ShowDialog();
                IspisArtikla();
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Artikli odabraniArtikl = row.DataBoundItem as Artikli;
                    odabraniArtikl.Obrisi();
                }
            }
        }

        private void PregledArtikla_Load(object sender, EventArgs e)
        {
            IspisArtikla();
        }
    }
}
