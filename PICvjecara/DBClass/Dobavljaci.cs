using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
   public class Dobavljaci
    {
        public int ID_dobavljac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int OIB { get; set; }
        public string Adresa { get; set; }

        public Dobavljaci()
        {
            
        }

        public void DohvatiDobavljace()
        {
            string q = "select * from Dobavljaci where Ime ='"+Ime+"'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);

            while(dr.Read())
            {
                ID_dobavljac = Convert.ToInt32( dr["ID_dobavljac"].ToString());
                Prezime = dr["Prezime"].ToString();
                OIB = Convert.ToInt32(dr["OIB"].ToString());
                Adresa = dr["Adresa"].ToString();


            }
            dr.Close();
            
        }

        /*public List<string> DobavljaciUListu()
        {
            List<string> lista = new List<string>();
            string q = "select * from Dobavljaci where Ime='" + Ime + "'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                lista.Add(dr["Ime"].ToString());
                lista.Add(dr["OIB"].ToString());
                lista.Add(dr["Adresa"].ToString());

            }
            dr.Close();
            return lista;
        }*/



        


    }
}
