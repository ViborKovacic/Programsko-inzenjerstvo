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
            Visible = false;
        }

        private void btnUnosNovogArtikla_Click(object sender, EventArgs e)
        {
            UnosArtikla openUnosArtikla = new UnosArtikla();
            openUnosArtikla.Show();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            /*otvoiti konekciju s bazom, ažurirati podatke naredba (alter),
            zatvoriti konekciju sa bazom*/

            DatabaseConnection newConnection = new DatabaseConnection();
            newConnection.ConnectionDB();

            SqlCommand comm = new SqlCommand();
            comm.Connection = DatabaseConnection.conn;

            /*comm.CommandText = "insert into Artikli values (@Naziv, @Cijena, @Kolicina, @ID_vrsta_artikla)";
            comm.Parameters.AddWithValue("Naziv", txtNaziv.Text);
            comm.Parameters.AddWithValue("Cijena", txtCijena.Text);
            comm.Parameters.AddWithValue("Kolicina", txtKolicina.Text);
            comm.Parameters.AddWithValue("ID_vrsta_artikla", cmboxTipArtikla.Text);
            comm.ExecuteNonQuery();

            MessageBox.Show();*/

            DatabaseConnection.conn.Close();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            /*otvoiti konekciju s bazom, obrisati podatke naredba (delete),
            zatvoriti konekciju sa bazom*/
        }

        private void PregledArtikla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet.Artikli);

        }
    }
}
