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
        int iDNarudzbenica;
        public frmPDF(int odabir)
        {
            iDNarudzbenica = odabir;
            
            InitializeComponent();
        }

        private void frmPDF_Load(object sender, EventArgs e)
        {

            //
            DataTable dtRepDob = GetArtikli();
            DataTable dtKorisnik = GetDataDobavljacKorisnik();


            ShowReportArtikli(dtRepDob, dtKorisnik);
            //ShowDobavljac(dtRepDob);
            //ShowID(dtRepID);


        }

        private DataTable GetDataDobavljacKorisnik()
        {
            DataTable dtData = new DataTable();
            using (SqlCommand cmd = new SqlCommand("ups_NarudzbenicaKorDobavljac", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@ID_Narudzbenica", iDNarudzbenica);
                SqlDataReader dr = cmd.ExecuteReader();
                dtData.Load(dr);
                dr.Close();
                con.Close();



            }
            return dtData;


        }
        private DataTable GetArtikli()
        {
            DataTable dtData = new DataTable();
            using (SqlCommand cmd = new SqlCommand("ups_NarudzbenicaArikli", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@ID_Narudzbenica", iDNarudzbenica);
                SqlDataReader dr = cmd.ExecuteReader();
                dtData.Load(dr);
                dr.Close();
                con.Close();



            }
            return dtData;

        }


        private void ShowReportArtikli( DataTable dtArtikli,DataTable dtKorisnik)
    {
        ReportDocument rdoc = new ReportDocument();
        rdoc.Load(@"C:\Users\Mario\Documents\GitHub\r16027\PICvjecara\CrystalReport2.rpt");
        rdoc.Database.Tables[0].SetDataSource(dtArtikli);//
        rdoc.Database.Tables[1].SetDataSource(dtKorisnik);

        crystalReportViewer1.ReportSource = rdoc;
    }
    //private void ShowDobavljac(DataTable dtRepDob)
    //{
    //    ReportDocument rdoc = new ReportDocument();
    //    rdoc.Load(@"CrystalReport4.rpt");
    //    rdoc.SetDataSource(dtRepDob);
    //    crystalReportViewer1.ReportSource = rdoc;
    //}
    //private void ShowID(DataTable dtRepID)
    //{
    //    ReportDocument rdoc = new ReportDocument();
    //    rdoc.Load(@"CrystalReport4.rpt");
    //    rdoc.SetDataSource(dtRepID);
    //    crystalReportViewer1.ReportSource = rdoc;
    //}


   



    private void btnPovratak_Click(object sender, EventArgs e)
    {

        con.Close();

        this.Close();
    }
}
    
}
