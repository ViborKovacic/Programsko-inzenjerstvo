using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridLoad;
using CrystalDecisions.CrystalReports;



namespace PICvjecara
{
    public partial class frmPregledRezervacija : Form
    {
        GridLoad.GridLoad gridLoad = new GridLoad.GridLoad(DatabaseConnection.Instance.ConnectionString);
        DBClass.Rezervacija rezervacija;
        public frmPregledRezervacija()
        {
            rezervacija = new DBClass.Rezervacija();
            ControlBox = false;
            InitializeComponent();
        }

        private void frmPregledRezervacija_Load(object sender, EventArgs e)
        {
            dgvRezervacija.DataSource = gridLoad.GridDataLoad(SqlCommandsGrid.qPrikazRezervacije);
        }

        private void dgvRezervacija_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRezervacija.SelectedRows.Count > 0)
            {
                int odabir = int.Parse(dgvRezervacija.SelectedCells[0].Value.ToString());
                
                
               
                rezervacija.DohvatiIzBaze(odabir);
               
            }
            
        }

       

        
    }
}
