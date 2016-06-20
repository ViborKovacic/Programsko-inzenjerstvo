using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara
{
    public class Artikli
    {
        static int id_artikla;
        static string naziv;
        static float cijena;// u decimal , al jos uvijek ne radi neznam zkj ici cu na konzultacije
        static int kolicina;
        static int id_vrsta_artikla;

        public int ID_artikla
        {
            get
            {
                return id_artikla;
            }

            set
            {
                if (id_artikla != value)
                {
                    id_artikla = value;
                }
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                if (naziv != value)
                {
                    naziv = value;
                }
            }
        }

        public float Cijena//float
        {
            get
            {
                return cijena;
            }

            set
            {
                if (cijena != value)
                {
                    cijena = value;
                }
            }
        }

        public int Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                if (kolicina != value)
                {
                    kolicina = value;
                }
            }
        }

        public int ID_vrsta_artikla
        {
            get
            {
                return id_vrsta_artikla;
            }

            set
            {
                if (id_vrsta_artikla != value)
                {
                    id_vrsta_artikla = value;
                }
            }
        }

        public Artikli()
        {
        }

        public Artikli(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_artikla = int.Parse(dr["ID_artikla"].ToString());
                Naziv = dr["Naziv"].ToString();
                Cijena = float.Parse(dr["Cijena"].ToString());//float
                Kolicina = int.Parse(dr["Kolicina"].ToString());
                ID_vrsta_artikla = int.Parse(dr["ID_vrsta_artikla"].ToString());
            }
        }

        public int Unos()
        {
            string sqlUpit = "";
            if (ID_artikla == 0)
            {
                sqlUpit = "INSERT INTO Artikli (Naziv, Cijena, Kolicina, ID_vrsta_artikla) VALUES ('" + Naziv + "','" + Cijena + "','" + Kolicina + "','" + ID_vrsta_artikla + "')";
            }

            else
            {
                sqlUpit = "UPDATE Artikli SET Naziv='" + Naziv + "', Cijena='" + Cijena + "', Kolicina='" + Kolicina + "', ID_vrsta_artikla='" + ID_vrsta_artikla + "' WHERE ID_artikla=" + ID_artikla;
            }

            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int Obrisi(int obrisiArikl)
        {
            string sqlUpit = "";
            sqlUpit = "DELETE FROM Artikli WHERE ID_artikla=" + obrisiArikl;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public static List<Artikli> DohvatiArtikle()
        {
            List<Artikli> lista = new List<Artikli>();
            string sqlUpit = "SELECT * FROM Artikli";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Artikli artikli = new Artikli(dr);
                lista.Add(artikli);
            }
            dr.Close();
            return lista;
        }
    }
}
