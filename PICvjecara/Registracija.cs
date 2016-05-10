using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICvjecara
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {

            //DatabaseConnection newConnection = new DatabaseConnection();
            //newConnection.ConnectionDB();

            //SqlCommand comm = new SqlCommand();
            //comm.Connection = DatabaseConnection.conn;

            //comm.CommandText = "insert into Korisnici values (@Ime, @Prezime, @Username, @Password, @Email, @Grad, @Adresa,@Telefon, @ID_tip_korisnika)";
            //comm.Parameters.AddWithValue("Ime", txtIme.Text);
            //comm.Parameters.AddWithValue("Prezime", txtPrezime.Text);
            //comm.Parameters.AddWithValue("Username", txtKorIme.Text);
            //comm.Parameters.AddWithValue("Password", txtLozinka.Text);
            //comm.Parameters.AddWithValue("Email", txtEmail.Text);
            //comm.Parameters.AddWithValue("Grad", txtGrad.Text);
            //comm.Parameters.AddWithValue("Adresa", txtAdresa.Text);
            //comm.Parameters.AddWithValue("Telefon", txtTelefon.Text);
            //comm.Parameters.AddWithValue("ID_tip_korisnika", txtTipKorisnika.Text);
            //comm.ExecuteNonQuery();

            //DatabaseConnection.conn.Close();

            //MessageBox.Show("Uspješno ste se registrirali");
            //Prijava openPrijava = new Prijava();
            //openPrijava.Show();
            //Visible = false;

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            //Prijava openPrijava = new Prijava();
            //openPrijava.Show();
            //Visible = false;
        }
    }
}
