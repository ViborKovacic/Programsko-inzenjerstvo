using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
   public class Stavka_rezervacije
    {

        private string datumFormat = "yyyy-MM-dd HH:MM:ss";
        public int ID_stavke_rezervacije { get; set; }
        public int Kolicina { get; set; }
        public int ID_rezervacija { get; set; }
        public int ID_nalog_za_prodaju { get; set; }
        public DateTime Datum_izrade { get; set; }
        public DateTime Datum_izvrsavanja { get; set; }

        public int Insert()
        {
            string q = "insert into Stavke_rezervacije (ID_rezervacija,ID_nalog_za_prodaju,Datum_izrade,Datum_izvrsavanja ) values ("+ ID_rezervacija
            + "," + ID_nalog_za_prodaju
            +",'"+Datum_izrade.ToString(datumFormat)
            +"','" + Datum_izvrsavanja.ToString(datumFormat) + "')";

            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
        public int Brisi(int IDBrisi)
        {
            string q = "delete from Stavke_rezervacije where ID_nalog_za_prodaju=" + IDBrisi;
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }


    }
}
