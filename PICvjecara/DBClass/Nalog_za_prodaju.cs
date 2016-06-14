using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    public class Nalog_za_prodaju
    {
        private string datumFormat = "yyyy-MM-dd HH:MM:ss";

        public int ID_nalog_za_prodaju { get; set; }
        public DateTime Datum { get; set; }
        public int ID_kupci { get; set; }
        public int ID_korisnik { get; set; }

        public int Insert()
        {
            string q = "insert into Nalog_za_prodaju (Datum,ID_kupci,ID_korisnik) values ('" + Datum.ToString(datumFormat)+"'," + ID_kupci+ "," + ID_korisnik+")";
            return DatabaseConnection.Instance.IzvirsiUput(q);
            
        }
        public void DohvatiIdNaloga()
        {
            string q = "select top 1 * from Nalog_za_prodaju order by ID_nalog_za_prodaju desc";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while(dr.Read())
            {
                ID_nalog_za_prodaju = int.Parse(dr["ID_nalog_za_prodaju"].ToString());
            }
            dr.Close();
        }
        public int Brisi(int IDBrisi)
        {
            string q = "delete from Nalog_za_prodaju where ID_nalog_za_prodaju=" + IDBrisi;
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
    }
}
