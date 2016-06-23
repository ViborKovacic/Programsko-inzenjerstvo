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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System.Configuration;


namespace PICvjecara
{
    public partial class frmRezervacijePDF : Form
    {
        SqlConnection con = new SqlConnection(DatabaseConnection.Instance.ConnectionString);
        
        int iDRezervacije = 0;
        
        public frmRezervacijePDF(int odabir)
        {
            iDRezervacije = odabir;
            InitializeComponent();
        }

        private void frmRezervacijePDF_Load(object sender, EventArgs e)
        {
            
            DataTable dtOstalo = GetData();
            ShowReport(dtOstalo);

        }

        private void ShowReport( DataTable dtOstalo)
        {
            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(@"C:\Users\Mario\Documents\GitHub\r16027\PICvjecara\CrystalReport1.rpt");
            rdoc.SetDataSource(dtOstalo);
            crystalReportViewer1.ReportSource = rdoc;
            
        }


        private DataTable GetData()
        {
            DataTable dtData = new DataTable();
            using (SqlCommand cmd = new SqlCommand("ups_Rezervacija", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@iDRezervacije", iDRezervacije);
                SqlDataReader dr = cmd.ExecuteReader();
                dtData.Load(dr);
                dr.Close();
                con.Close();



            }
            return dtData;
        }
    }
}
