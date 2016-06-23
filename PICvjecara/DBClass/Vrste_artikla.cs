﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    public class Vrste_artikla
    {
        public int ID_vrsta_artikla { get; set; }
        public string Vrsta { get; set; }
        public string Url { get; set; }
        static List<string> listaVrsta = new List<string>();



        public void DohvatiVrsteArtikla(int IdVrsteArtikla)
        {
            string q = "select * from Vrsta_artikla where ID_vrsta_artikla=" + IdVrsteArtikla;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_vrsta_artikla = int.Parse(dr["ID_vrsta_artikla"].ToString());
                Vrsta = dr["Vrsta"].ToString();
            }
            dr.Close();

        }
        public int DodajNovuVrstu()
        {
            string q = "insert into Vrsta_artikla (Vrsta) values ('" + Vrsta + "')";
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }

        public Vrste_artikla()
        { }

        public Vrste_artikla(DbDataReader dr)
        {
            if (dr != null)
            {
                Vrsta = dr["Vrsta"].ToString();
                Url = dr["Url"].ToString();
            }
        }

        public int Unos()
        {
            string sqlUpit = "";
            if (ID_vrsta_artikla == 0)
            {
                sqlUpit = "INSERT INTO Vrsta_artikla (Vrsta, Url) VALUES ('" + Vrsta + "','" + Url + "')";
            }

            else
            {
                sqlUpit = "UPDATE Vrsta_artikla SET Vrsta='" + Vrsta + "', Url='" + Url + "' WHERE ID_artikla=" + ID_vrsta_artikla;
            }

            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public  List<Vrste_artikla> DohvatiVrstuArtikla()
        {
            List<Vrste_artikla> lista = new List<Vrste_artikla>();
            string sqlUpit = "SELECT Vrsta FROM Vrsta_artikla";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Vrste_artikla vrsta = new Vrste_artikla(dr);
                lista.Add(vrsta);
                
            }
            dr.Close();
            return lista;
        }

        public int DohvatiVrstuPoID(string vrstaArtikla)
        {
            List<Vrste_artikla> lista = new List<Vrste_artikla>();
            string sqlUpit = "SELECT ID_vrsta_artikla FROM Vrsta_artikla WHERE Vrsta='" + vrstaArtikla + "'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            dr.Read();
            int broj = dr.FieldCount;
            dr.Close();
            
            return broj;
        }

        public List<Vrste_artikla> DohvatiVrstuUrlArtikla()
        {
            List<Vrste_artikla> lista = new List<Vrste_artikla>();
            string sqlUpit = "SELECT Vrsta, Url FROM Vrsta_artikla";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Vrste_artikla vrsta = new Vrste_artikla(dr);
                lista.Add(vrsta);

            }
            dr.Close();
            return lista;
        }

    }
}
