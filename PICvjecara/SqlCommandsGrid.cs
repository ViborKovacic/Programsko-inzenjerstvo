using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara
{
    public static class SqlCommandsGrid
    {
        public static string qNarudzbe = "select n.ID_narudzbenice as 'Broj Narudžbe',va.Vrsta as 'Vrsta Artikla',a.Naziv as 'Naziv Artikla',d.Ime as 'Dobavljač', n.datum_vrijeme as 'Datum Narudžbe',k.ime as 'korisnik', n.kolicina as 'Naručena Količina' from Narudzbenica n , Dobavljaci d, Korisnici k, Stavke_narudzbenice sn, Artikli a , Vrsta_artikla va where d.ID_dobavljac=n.ID_dobavljac and n.ID_korisnici=k.ID_korisnik and  n.ID_narudzbenice=sn.ID_narudzbenice and a.ID_artikla = sn.ID_artikla and a.ID_vrsta_artikla = va.ID_vrsta_artikla";
        public static string qRezervacije = "select nzp.ID_nalog_za_prodaju as 'Broj rezervacije', ku.Ime as 'Rezervirao',tr.Vrsta as 'Rezervacija',r.Cijena as 'Cijena',sr.Kolicina as 'Količina', nzp.Datum as 'Datum Rezervacije',k.Ime as 'Zaprimio' from Nalog_za_prodaju nzp, Kupci ku, Korisnici k, Stavke_rezervacije sr, Rezervacija r, Tip_rezervacije tr where ku.ID_kupca = nzp.ID_kupci and k.ID_korisnik = nzp.ID_korisnik  and nzp.ID_nalog_za_prodaju=sr.ID_nalog_za_prodaju and sr.ID_rezervacija=r.ID_rezervacije and r.ID_tip_rezervacije =tr.ID_tip_rezervacije";
    }

    //ovdje je prikazan source code od dll file-a, ovo samo sluzi da se ne mora skidat neki poseban program za otvaranje dll file da se vidi funkcionalnost
    #region Source DLL
    /*public class GridLoad
    {

        private SqlConnection conn = new SqlConnection("Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=16027_DB;Persist Security Info=True;User ID=16027_User;Password=uJYptMsf");

        private void OpenCon()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private void CloseCon()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable GridLoadData(string q)
        {

            DbDataReader dr;
            SqlCommand comm = new SqlCommand(q, conn);
            OpenCon();
            dr = comm.ExecuteReader();
            DataTable dtDetalji = new DataTable();
            dtDetalji.Load(dr);
            dr.Close();
            CloseCon();
            return dtDetalji;
        }
    }*/
    #endregion

}
