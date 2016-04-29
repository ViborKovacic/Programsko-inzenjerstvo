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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string KorIme = "";
            string Lozinka = "";
            int brojac = 0;

            DatabaseConnection newConnection = new DatabaseConnection();
            newConnection.ConnectionDB();

            SqlCommand comm = new SqlCommand();
            comm.Connection = DatabaseConnection.conn;
            comm.CommandText = "select count(*), Username, Password from Korisnici where Username='" + txtKorIme.Text + "' group by Username, Password";
            comm.ExecuteNonQuery();

            brojac = Convert.ToInt32(comm.ExecuteScalar());

            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            
            if ( brojac > 0)
            {
                KorIme = (read["Username"].ToString());
                Lozinka = (read["Password"].ToString());
                read.Close();

                if (txtKorIme.Text == KorIme && txtLozinka.Text == Lozinka)
                {
                    frmCvjecarna openCvjecarna = new frmCvjecarna();                    
                    openCvjecarna.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Pogrešna lozinka");
                }
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime");
            }

            DatabaseConnection.conn.Close();           
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija openRegistracija = new Registracija();
            openRegistracija.Show();
            Visible = false;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
