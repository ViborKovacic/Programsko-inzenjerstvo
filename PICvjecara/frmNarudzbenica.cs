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
    public partial class frmNarudzbenica : Form
    {
        //private DBOperacije.OperacijeNarudzba Narudzbenica;

              
        //public List<string> dobavljac;
        //public List<string> NaruceniArtikli;
        
        public frmNarudzbenica()
        {
            //InitializeComponent();
            //grpBoxNovi.Enabled = false;
            ////grpBoxPostojeci.Enabled = false;
            ////grpBoxZavrseno.Enabled = false;
            //DohvatiVrsteArtikla();
            //Narudzbenica = new DBOperacije.OperacijeNarudzba();
            //DohvatiDobavljaca();
            ////treba doraditi
            //btnEmail.Enabled = false;
            //btnPDF.Enabled = false;
            //btnNoviArtikli.Enabled = false;
            

            ////liste
            //dobavljac = new List<string>();
            //NaruceniArtikli = new List<string>();
           


        }

        private void frmNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this._16027_DBDataSet.Narudzbenica);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);
            // TODO: This line of code loads data into the '_16027_DBDataSet.Dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.Fill(this._16027_DBDataSet.Dobavljaci);

        }

        private void btnPostojeciArtikl_Click(object sender, EventArgs e)
        {
            //grpBoxPostojeci.Enabled = true;
            //if (grpBoxNovi.Enabled)
            //{
            //    grpBoxNovi.Enabled = false;
            //}
        }

        private void btnNoviArtikli_Click(object sender, EventArgs e)
        {
            //grpBoxNovi.Enabled = true;
            //if (grpBoxPostojeci.Enabled)
            //{
            //    grpBoxPostojeci.Enabled = false;
            //}
        }

        private void btnIzradinalogPostojeci_Click(object sender, EventArgs e)
        {
            //int IDdobavljaca = 0;
            //string naruceniArtikli = "";
            //grpBoxZavrseno.Enabled = true;

            //SqlDataReader dr;
            //string q = "select * from Dobavljaci where Ime='"+cmbDobavljac.GetItemText( cmbDobavljac.SelectedItem.ToString())+"'";

            //db baza = new db();
            //SqlCommand comm = new SqlCommand(q, baza.conn);
            //baza.OpenCon();
            //dr = comm.ExecuteReader();
            //while (dr.Read())
            //{
            //    IDdobavljaca = Convert.ToInt32(dr["ID_dobavljac"].ToString());
            //    dobavljac.Add(dr["Ime"].ToString());
            //    dobavljac.Add(dr["OIB"].ToString());
            //    dobavljac.Add(dr["Adresa"].ToString());
            //}
            //dr.Close();
            //baza.CloseCon();
            
            //Narudzbenica.CreateNarudzbenicaStaro(IDdobavljaca);

            //naruceniArtikli = "Naručeni artikli su: " + Environment.NewLine + "Naziv artikla: " + cmbNazivArtikla.SelectedItem.ToString() +
            //    Environment.NewLine + "Vrsta artikla: " + cmbVrstaArtikla.SelectedItem.ToString() + Environment.NewLine +
            //    "Količina: " + txtKolicinaPostojeci.Text.ToString()+Environment.NewLine;
            //NaruceniArtikli.Add(naruceniArtikli);
            //Ispis();
            


        }
       private void DohvatiDobavljaca()
        {
            //cmbDobavljac.Items.Clear();
            //SqlDataReader dr;
            //string q = "select * from Dobavljaci";
            //db baza = new db();
            //SqlCommand comm = new SqlCommand(q, baza.conn);
            //baza.OpenCon();
            //dr = comm.ExecuteReader();
            //while (dr.Read())
            //{
            //    cmbDobavljac.Items.Add(dr["Ime"].ToString());
            //}
            //dr.Close();
            //baza.CloseCon();
            
        }

        private void DohvatiVrsteArtikla()
        {
            //cmbVrstaArtikla.Items.Clear();
            //SqlDataReader dr;
            //string q = "select Vrsta from Vrsta_artikla";
            //db baza = new db();

            //SqlCommand comm = new SqlCommand(q, baza.conn);
            //baza.OpenCon();
            //dr = comm.ExecuteReader();

            //while (dr.Read())
            //{
            //    cmbVrstaArtikla.Items.Add(dr[0].ToString());

            //}
            //dr.Close();
            //baza.CloseCon();

            
        }
        private void PopuniArtikle()
        {
            //string q = "select Artikli.Naziv from Artikli, Vrsta_artikla where Vrsta_artikla.ID_vrsta_artikla=Artikli.ID_vrsta_artikla and Vrsta_artikla.Vrsta='" + cmbVrstaArtikla.SelectedItem.ToString() + "'";

            //SqlDataReader dr;
            //cmbNazivArtikla.Items.Clear();
            
            //db baza = new db();
            
            //SqlCommand comm = new SqlCommand(q,baza.conn);
            //baza.OpenCon();
            //dr = comm.ExecuteReader();

            //while (dr.Read())
            //{
            //    cmbNazivArtikla.Items.Add(dr[0].ToString());
            //}
            //dr.Close();
            //baza.CloseCon();



        }
        private void Ispis()
        {
            //foreach (string s in NaruceniArtikli)
            //{
            //    txtNaruceniArtikli.Text = s.ToString()+txtNaruceniArtikli.Text;

            //}
            //MessageBox.Show("Narudžba je kreirana i pohranjena!");
        }
        private void cmbVrstaArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PopuniArtikle();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            //frmCvjecarna frmCvijece = new frmCvjecarna();
            //frmCvijece.Visible = true;
            //this.Close();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            //frmSenaEmail email = new frmSenaEmail();
            //email.Visible = true;
        }
    }
}
