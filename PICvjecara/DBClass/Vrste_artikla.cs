using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    public class Vrste_artikla
    {
        public int ID_vrsta_artikla { get; set; }
        public string Vrsta { get; set; }
        static List<string> listaVrsta = new List<string>();



        public void DohvatiIDVrsteArtikla()
        {
            string q = "select ID_vrsta_artikla from Vrsta_artikla where Vrsta='" + Vrsta+"'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_vrsta_artikla = int.Parse(dr["ID_vrsta_artikla"].ToString());
            }
            dr.Close();
            
        }
        public int DodajNovuVrstu()
        {
            string q = "insert into Vrsta_artikla (Vrsta) values ('" + Vrsta + "')";
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
        public void DohvatiNoviID()
        {
            string q = "select top 1 * from Vrsta_artikla order by ID_vrsta_artikla desc";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_vrsta_artikla = int.Parse(dr["ID_vrsta_artikla"].ToString());
            }
            dr.Close();

        }
       /* public List<string> ListaVrsta()
        {
            listaVrsta.Add(Vrsta);
            return listaVrsta;
        }*/
    }

   
}
