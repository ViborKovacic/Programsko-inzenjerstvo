using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
   public class Stavke_rezervacije
    {
       

        public int ID_stavke_rezervacije { get; set; }
        public int Kolicina { get; set; }
        public int ID_rezervacija { get; set; }
        public int ID_nalog_za_prodaju { get; set; }

        public int Insert()
        {
            string q = "insert into Stavke_rezervacije (Kolicina,ID_rezervacija,ID_nalog_za_prodaju ) values ("+ Kolicina
            + "," + ID_rezervacija
            + "," + ID_nalog_za_prodaju+")";

            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
        public int Brisi(int IDBrisi)
        {
            string q = "delete from Stavke_rezervacije where ID_nalog_za_prodaju=" + IDBrisi;
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }


    }
}
