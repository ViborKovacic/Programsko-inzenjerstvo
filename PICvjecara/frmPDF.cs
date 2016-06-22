using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using System.Configuration;



namespace PICvjecara
{
    public partial class frmPDF : Form
    {

        SqlConnection con = new SqlConnection(DatabaseConnection.Instance.ConnectionString);
         int iDNarudzbenica=0;
         public frmPDF(int odabir)
        {
            iDNarudzbenica = odabir;
            ControlBox = false;
            InitializeComponent();
        }

        private void frmPDF_Load(object sender, EventArgs e)
        {

            DataTable dtReportData = GetData();
            DataTable dtRepDob = GetDobavljac();
            DataTable dtRepID = GetNarID();

            ShowReportArtikli(dtReportData);
            ShowDobavljac(dtRepDob);
            ShowID(dtRepID);


        }

        private void ShowReportArtikli(DataTable dtReportData)
        {
            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(@"CrystalReport4.rpt");
            rdoc.SetDataSource(dtReportData);
            crystalReportViewer1.ReportSource = rdoc;
        }
        private void ShowDobavljac(DataTable dtRepDob)
        {
            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(@"CrystalReport4.rpt");
            rdoc.SetDataSource(dtRepDob);
            crystalReportViewer1.ReportSource = rdoc;
        }
        private void ShowID(DataTable dtRepID)
        {
            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(@"CrystalReport4.rpt");
            rdoc.SetDataSource(dtRepID);
            crystalReportViewer1.ReportSource = rdoc;
        }


        private DataTable GetData()
        {
            DataTable dtData = new DataTable();
            using (SqlCommand cmd = new SqlCommand("usp_ReportArtikli", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@iDNarudzbenica", iDNarudzbenica);
                SqlDataReader dr = cmd.ExecuteReader();
                dtData.Load(dr);
                dr.Close();
                con.Close();



            }
            return dtData;
            
            
        }
        private DataTable GetDobavljac()
        {
            DataTable dtData = new DataTable();
            using (SqlCommand cmd = new SqlCommand("usp_ReportDobavljac", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@iDNarudzbenica", iDNarudzbenica);
                SqlDataReader dr = cmd.ExecuteReader();
                dtData.Load(dr);
                dr.Close();
                con.Close();



            }
            return dtData;

        }
        private DataTable GetNarID()
        {
            DataTable dtData = new DataTable();
            using (SqlCommand cmd = new SqlCommand("usp_SifraNarudzbenice", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@iDNarudzbenica", iDNarudzbenica);
                SqlDataReader dr = cmd.ExecuteReader();
                dtData.Load(dr);
                dr.Close();
                con.Close();



            }

            return dtData;
        }


       

        private void btnPovratak_Click(object sender, EventArgs e)
        {

            con.Close();

            this.Close();
        }
    }
}
