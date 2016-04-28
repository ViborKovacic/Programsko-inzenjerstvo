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
    public partial class AzurirajArtikl : Form
    {
        public AzurirajArtikl()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int broj = 0;
            if (int.TryParse(txtCijena.Text.Trim(), out broj))
            {
                DatabaseConnection newConnection = new DatabaseConnection();
                newConnection.ConnectionDB();

                SqlCommand comm = new SqlCommand();
                comm.Connection = DatabaseConnection.conn;

                comm.CommandText = "update Artikli set Naziv='" + txtNaziv.Text + "',Cijena='" + txtCijena.Text + "',Kolicina='" + txtKolicina.Text + "',ID_vrsta_artikla='" + cmboxTipArtikla.Text + "'where ID_artikla = '" + cmbBrojArtikla.Text + "' ;";
                comm.ExecuteNonQuery();

                MessageBox.Show("Uspiješno ste ažurirali", "Dodano");

                DatabaseConnection.conn.Close();
            }

            else
            {
                MessageBox.Show("Cijena i količina moraju biti brojevi");
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void AzurirajArtikl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16027_DBDataSet.Artikli);

        }
    }
}
