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
            txtNaziv.Text = "Naziv artikla";
            txtCijena.Text = "Unesite cijenu u kn";
            txtKolicina.Text = "Unesite količinu";
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
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

        private void UnosArtikla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);

        }
    }
}
