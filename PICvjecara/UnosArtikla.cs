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
    public partial class UnosArtikla : Form
    {
        public UnosArtikla()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            cmboxTipArtikla.Text = "Odaberi tip";
            txtNaziv.Clear();
            txtCijena.Clear();
            txtKolicina.Clear();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            PregledArtikla openPregledArtikla = new PregledArtikla();
            openPregledArtikla.Show();
            Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DatabaseConnection newConnection = new DatabaseConnection();
            newConnection.ConnectionDB();

            SqlCommand comm = new SqlCommand();
            comm.Connection = DatabaseConnection.conn;

            comm.CommandText = "insert into Artikli values (@Naziv, @Cijena, @Kolicina, @ID_vrsta_artikla)";
            comm.Parameters.AddWithValue("Naziv", txtNaziv.Text);
            comm.Parameters.AddWithValue("Cijena", txtCijena.Text);
            comm.Parameters.AddWithValue("Kolicina", txtKolicina.Text);
            comm.Parameters.AddWithValue("ID_vrsta_artikla", cmboxTipArtikla.Text);
            comm.ExecuteNonQuery();

            MessageBox.Show(cmboxTipArtikla.Text + "  dodano." + Environment.NewLine +
                            txtNaziv.Text + " dodano." + Environment.NewLine + txtCijena.Text +
                            " dodano." + Environment.NewLine + txtKolicina.Text + " dodano.", "Dodano");

            DatabaseConnection.conn.Close();
        }
    }
}
