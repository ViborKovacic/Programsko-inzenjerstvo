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
    public partial class frmPregledNarudzbi : Form
    {
        public SqlDataAdapter dataAdapter;
        public SqlCommandBuilder builder;
        public DataSet ds;

        public frmPregledNarudzbi()
        {
            InitializeComponent();
            Refresh.Start();
        }

        private void Refresh_Tick(object sender, EventArgs e)
        {
            string q = "select Artikli.Naziv as [Ime Artikla], Vrsta_artikla.Vrsta as [Vrsta artikla],Narudzbenica.Datum_vrijeme as [Datum naručivanja], Dobavljaci.Ime as [Ime dobavljača],Korisnici.Ime as [Naručio] from ";
            db baza = new db();
            SqlCommand comm = new SqlCommand(q, baza.conn);
            baza.OpenCon();
            dataAdapter = new SqlDataAdapter(comm);
            builder = new SqlCommandBuilder(dataAdapter);
            ds = new DataSet();

            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            baza.CloseCon();

        }
    }
}
