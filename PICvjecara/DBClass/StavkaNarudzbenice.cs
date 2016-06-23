using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
   public class StavkaNarudzbenice
    {
        public int ID_narudzbenice { get; set; }
        public int ID_artikla { get; set; }
        public int Kolicina { get; set; }


        public int Insert()
        {
            string q = "insert into Stavke_narudzbenice (ID_artikla,ID_narudzbenice,Kolicina) values (" + ID_artikla + ", " + ID_narudzbenice + "," + Kolicina + ")";
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }

        public int Brisi(int IDBrisi)
        {
            string q = "delete from Stavke_narudzbenice where ID_narudzbenice=" + IDBrisi;
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
    }
}
