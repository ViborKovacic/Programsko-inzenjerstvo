﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections;
using System.ComponentModel;

namespace PICvjecara.DBClass
{
    public class Artikli
    {
        public int ID_artikla { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public int ID_vrsta_artikla { get; set; }

        public static BindingList<Artikli> listaArtikla = new BindingList<Artikli>();

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



            }
            dr.Close();
        }
        public BindingList<Artikli> DohvatiListu(Artikli artikli)
        {
            listaArtikla.Add(artikli);
            return listaArtikla;
        }
        //public int DodajArtikl()
        //{
        //    string q = "insert into Artikli (Naziv,Cijena,Kolicina,ID_vrsta_artikla) values ('" + Naziv + "'," + Cijena + "," + Kolicina + "," + ID_vrsta_artikla + ")";
        //    return DatabaseConnection.Instance.IzvirsiUput(q);
        //}
        //public void DohvatiIDNovogArtikla()
        //{
        //    string q = "select top 1 * from Artikli order by ID_artikla desc";
        //    DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
        //    while (dr.Read())
        //    {
        //        ID_artikla = int.Parse(dr["ID_artikla"].ToString());
        //    }
        //    dr.Close();

        //}
        /* public List<string> ListaArtikla()
         {
             listaArtikla.Add(Cijena.ToString());
             listaArtikla.Add(Kolicina.ToString());
             listaArtikla.Add(Naziv);
             return listaArtikla;
         }*/
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

        public int Obrisi(int obrisiArtikl)
        {
            string sqlUpit = "";
            sqlUpit = "DELETE FROM Artikli WHERE ID_artikla=" + obrisiArtikl;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public static List<DBClass.Artikli> DohvatiArtikle(int ID_Artikla)
        {
            List<DBClass.Artikli> lista = new List<DBClass.Artikli>();
            string sqlUpit = "SELECT * FROM Artikli WHERE ID_artikla=" + ID_Artikla;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                DBClass.Artikli artikli = new DBClass.Artikli(dr);
                lista.Add(artikli);
            }
            dr.Close();
            return lista;
        }
    }
}
