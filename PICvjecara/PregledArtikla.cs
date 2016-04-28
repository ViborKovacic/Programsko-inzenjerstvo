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
        public SqlCommandBuilder builder = new SqlCommandBuilder();
        public SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public DataSet ds = new DataSet();

        public PregledArtikla()
        {
            InitializeComponent();
            ControlBox = false;
            timerRefresh.Start();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna openCvjecarna = new frmCvjecarna();
            openCvjecarna.Show();
            Visible = false;
        }

        private void btnUnosNovogArtikla_Click(object sender, EventArgs e)
        {
            UnosArtikla openUnosArtikla = new UnosArtikla();
            openUnosArtikla.Show();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajArtikl openAzuriraj = new AzurirajArtikl();
            openAzuriraj.Show();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            DatabaseConnection newConnection = new DatabaseConnection();
            newConnection.ConnectionDB();

            SqlCommand comm = new SqlCommand();
            comm.Connection = DatabaseConnection.conn;
            comm.CommandText = "delete from Artikli where ID_artikla='" + cmbBrojArtikla.Text + "'";

            MessageBox.Show("Artikl broj " + cmbBrojArtikla.Text + ". uspiješno orbisan");
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            DatabaseConnection newConnection = new DatabaseConnection();
            newConnection.ConnectionDB();

            SqlCommand comm = new SqlCommand();
            comm.Connection = DatabaseConnection.conn;
            comm.CommandText = "select Artikli.ID_artikla as [Broj artikla], Artikli.Naziv, Artikli.Cijena, Artikli.Kolicina, Vrsta_artikla.Vrsta as [Vrsta artikla] from Artikli inner join Vrsta_artikla on Artikli.ID_vrsta_artikla = Vrsta_artikla.ID_vrsta_artikla";

            dataAdapter = new SqlDataAdapter(comm);

            builder = new SqlCommandBuilder(dataAdapter);

            ds = new DataSet();

            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            DatabaseConnection.conn.Close();
        }
    }
}
