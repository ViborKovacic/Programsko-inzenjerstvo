﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
    public class Stavka_racuna
    {
        public int ID_stavke_racuna { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public float Iznos { get; set; }
        public string Datum { get; set; }
        public int ID_korisnika { get; set; }
        public int ID_artikli { get; set; }
        public int ID_nalog_za_prodaju { get; set; }

        public Stavka_racuna()
        {
        }

        public Stavka_racuna(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_stavke_racuna = int.Parse(dr["ID_stavke_racuna"].ToString());
                Naziv = dr["Naziv"].ToString();
                Iznos = float.Parse(dr["Iznos"].ToString());//float
                Kolicina = int.Parse(dr["Kolicina"].ToString());
                Datum = DateTime.Now.ToString("dd/MM/yyyy");
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
                sqlUpit = "INSERT INTO Stavke_racuna (Naziv, Iznos, Kolicina, Datum, ID_korisnika, ID_artikli) VALUES ('" + Naziv + "','" + Iznos + "','" + Kolicina + "','" + Datum + "','" + ID_korisnika + "','" + ID_artikli + "')";
            }

            else
            {
                sqlUpit = "UPDATE Stavke_racuna SET Naziv='" + Naziv + "', Iznos='" + Iznos + "', Kolicina='" + Kolicina + "', Datum='" + Datum + "', ID_korisnika='" + ID_korisnika + "', ID_artikli='" + ID_artikli + "' WHERE ID_stavke_racuna=" + ID_stavke_racuna;
            }

            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int Obrisi(int obrisiStavku)
        {
            string sqlUpit = "";
            sqlUpit = "DELETE FROM Stavke_racuna WHERE ID_stavke_racuna=" + obrisiStavku;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int ObrisiSve()
        {
            string sqlUpit = "DELETE FROM Stavke_racuna WHERE ID_stavke_racuna=ID_stavke_racuna";
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public static List<DBClass.Stavka_racuna> DohvatiSveStavke()
        {
            List<DBClass.Stavka_racuna> lista = new List<DBClass.Stavka_racuna>();
            string sqlUpit = "SELECT DISTINCT * FROM Stavke_racuna";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                DBClass.Stavka_racuna stavke = new DBClass.Stavka_racuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }

        public static List<DBClass.Stavka_racuna> DohvatiOznaceneArtikle(int ID_stavke)
        {
            List<DBClass.Stavka_racuna> lista = new List<DBClass.Stavka_racuna>();
            string sqlUpit = "SELECT * FROM Artikli WHERE ID_artikla=" + ID_stavke;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                DBClass.Stavka_racuna stavke = new DBClass.Stavka_racuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }

        public int UmanjiKolicinuArtikli(int brojArtikla)
        {
            string sqlUpit = "UPDATE Stavke_racuna SET Kolicina = Kolicina - 1 WHERE ID_artikli=" + brojArtikla; 
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int Update()
        {
            string sqlUpit = "UPDATE Stavke_racuna SET Kolicina = Kolicina + 1 WHERE ID_artikli=" + ID_artikli;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }
    }
}
