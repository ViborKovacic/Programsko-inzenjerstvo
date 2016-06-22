using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace PICvjecara
{
    public partial class frmProdaja : Form
    {
        public DBClass.Artikli artikli;
        public List<DBClass.Artikli> lista;
        public frmProdaja()
        {
            InitializeComponent();
        }

        private void listaArtikla(string listaProdaja)
        {
            lista = new List<DBClass.Artikli>();
            lista = DBClass.Artikli.DohvatiartikleProdaja(listaProdaja);

            if (lista != null)
            {
                dataGridView1.DataSource = lista;
            }
            else
            {
                MessageBox.Show("Trenutno nema na skladištu traženog artikla");
            }
        }

        private void frmProdaja_Load(object sender, EventArgs e)
        {

            
        }

        private void picCvijece_Click(object sender, EventArgs e)
        {
            string proslijedi = lblCvijece.Text;
            lblcon.Text = proslijedi;
            listaArtikla(proslijedi);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
