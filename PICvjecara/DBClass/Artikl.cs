using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections;
using System.ComponentModel;

namespace PICvjecara.DBClass
{
    public class Artikl
    {
        public int ID_artikla { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public int ID_vrsta_artikla { get; set; }

        public int Narucena_kolicina { get; set; }
        public static BindingList<Artikl> listaArtikla = new BindingList<Artikl>();

        public void DohvatiArtikl(int IdArtikla)
        {
            string q = "select * from Artikli where ID_artikla=" + IdArtikla;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_artikla = int.Parse(dr["ID_artikla"].ToString());
                Naziv = dr["Naziv"].ToString();
                Cijena = float.Parse(dr["Cijena"].ToString());
                Kolicina = int.Parse(dr["Kolicina"].ToString());
                ID_vrsta_artikla = int.Parse(dr["ID_vrsta_artikla"].ToString());
                Narucena_kolicina = int.Parse(dr["Narucena_kolicina"].ToString());



            }
            dr.Close();
        }
        public BindingList<Artikl> DohvatiListu(Artikl artikli)
        {
            listaArtikla.Add(artikli);
            return listaArtikla;
        }
        public int DodajNarucenuKolicinu(int iDArtikla)
        {
            string q = "update Artikli set Narucena_kolicina =" + Kolicina + " where ID_artikla=" + iDArtikla;
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }

        public Artikl()
        {
        }

        public Artikl(DbDataReader dr)
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

        public int Obrisi(int obrisiArtikl)
        {
            string sqlUpit = "";
            sqlUpit = "DELETE FROM Artikli WHERE ID_artikla=" + obrisiArtikl;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public static List<DBClass.Artikl> DohvatiSveArtikle()
        {
            List<DBClass.Artikl> lista = new List<DBClass.Artikl>();
            string sqlUpit = "SELECT * FROM Artikli";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                DBClass.Artikl artikli = new DBClass.Artikl(dr);
                lista.Add(artikli);
            }
            dr.Close();
            return lista;
        }

        public static List<DBClass.Artikl> DohvatiArtikle(int ID_Artikla)
        {
            List<DBClass.Artikl> lista = new List<DBClass.Artikl>();
            string sqlUpit = "SELECT * FROM Artikli WHERE ID_artikla=" + ID_Artikla;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                DBClass.Artikl artikli = new DBClass.Artikl(dr);
                lista.Add(artikli);
            }
            dr.Close();
            return lista;
        }

        public static List<DBClass.Artikl> DohvatiArtikleProdaja(string vrstaArtikla)
        {
            List<DBClass.Artikl> lista = new List<DBClass.Artikl>();
            string sqlUpit = "SELECT a.ID_artikla, a.Naziv, a.Cijena, a.Kolicina, a.ID_vrsta_artikla FROM Artikli a, Vrsta_artikla v  WHERE a.ID_vrsta_artikla=v.ID_vrsta_artikla AND v.Vrsta ='" + vrstaArtikla + "'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);

            while (dr.Read())
            {
                DBClass.Artikl artikli = new DBClass.Artikl(dr);
                lista.Add(artikli);
            }
            dr.Close();
            return lista;           
        }

        public static List<DBClass.Artikl> DohvatiBrojArtikla(int brojArtikla)
        {
            List<DBClass.Artikl> lista = new List<DBClass.Artikl>();
            string sqlUpit = "SELECT a.ID_artikla, a.Naziv, a.Cijena, a.Kolicina, a.ID_vrsta_artikla FROM Artikli a, Vrsta_artikla v  WHERE a.ID_vrsta_artikla=v.ID_vrsta_artikla AND a.ID_artikla LIKE('" + brojArtikla + "%')";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);

            while (dr.Read())
            {
                DBClass.Artikl artikli = new DBClass.Artikl(dr);
                lista.Add(artikli);
            }
            dr.Close();
            return lista;
        }

        public static List<DBClass.Artikl> DohvatiNazivArtikla(string nazivArtikla)
        {
            List<DBClass.Artikl> lista = new List<DBClass.Artikl>();
            string sqlUpit = "SELECT a.ID_artikla, a.Naziv, a.Cijena, a.Kolicina, a.ID_vrsta_artikla FROM Artikli a, Vrsta_artikla v  WHERE a.ID_vrsta_artikla=v.ID_vrsta_artikla AND a.Naziv LIKE('" + nazivArtikla + "%')";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);

            while (dr.Read())
            {
                DBClass.Artikl artikli = new DBClass.Artikl(dr);
                lista.Add(artikli);
            }
            dr.Close();
            return lista;
        }

        public static int SmanjnjeKolicine(int brojArtikla, int kolicina)
        {
            string sqlUpit = "UPDATE Artikli SET Kolicina = Kolicina - '" + kolicina + "' WHERE ID_artikla = " + brojArtikla;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }
    }
}
