using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
    public class Stavke_racuna
    {
        public int ID_stavke_racuna { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public float Cijena { get; set; }
        public DateTime Datum { get; }
        public int ID_korisnika { get; set; }
        public int ID_artikli { get; set; }
        public int ID_nalog_za_prodaju { get; set; }

        public Stavke_racuna()
        {
        }

        public Stavke_racuna(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_stavke_racuna = int.Parse(dr["ID_stavke_racuna"].ToString());
                Naziv = dr["Naziv"].ToString();
                Cijena = float.Parse(dr["Iznos"].ToString());//float
                Kolicina = int.Parse(dr["Kolicina"].ToString());
                Datum = Convert.ToDateTime(dr["Datum"].ToString());
                ID_korisnika = int.Parse(dr["ID_korisnika"].ToString());
                ID_artikli = int.Parse(dr["ID_artikli"].ToString());
                //ID_nalog_za_prodaju = int.Parse(dr["ID_nalog_za_prodaju"].ToString());

            }
        }

        public int Unos()
        {
            string sqlUpit = "";
            if (ID_stavke_racuna == 0)
            {
                sqlUpit = "INSERT INTO Stavke_racuna (Naziv, Iznos, Kolicina, Datum, ID_korisnika, ID_artikli) VALUES ('" + Naziv + "','" + Cijena + "','" + Kolicina + "','" + Datum + "','" + ID_korisnika + "','" + ID_artikli + "')";
            }

            else
            {
                sqlUpit = "UPDATE Stavke_racuna SET Naziv='" + Naziv + "', Iznos='" + Cijena + "', Kolicina='" + Kolicina + "', Datum='" + Datum + "', ID_korisnika='" + ID_korisnika + "', ID_artikli='" + ID_artikli + "' WHERE ID_stavke_racuna=" + ID_stavke_racuna;
            }

            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int Obrisi(int obrisiStavku)
        {
            string sqlUpit = "";
            sqlUpit = "DELETE FROM Stavke_racuna WHERE ID_stavke_racuna=" + obrisiStavku;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public static List<DBClass.Stavke_racuna> DohvatiSveStavke()
        {
            List<DBClass.Stavke_racuna> lista = new List<DBClass.Stavke_racuna>();
            string sqlUpit = "SELECT * FROM Stavke_racuna";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                DBClass.Stavke_racuna stavke = new DBClass.Stavke_racuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }

        public static List<DBClass.Stavke_racuna> DohvatiOznaceneArtikle(int ID_stavke)
        {
            List<DBClass.Stavke_racuna> lista = new List<DBClass.Stavke_racuna>();
            string sqlUpit = "SELECT * FROM Artikli WHERE ID_artikla=" + ID_stavke;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                DBClass.Stavke_racuna stavke = new DBClass.Stavke_racuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }
    }
}
