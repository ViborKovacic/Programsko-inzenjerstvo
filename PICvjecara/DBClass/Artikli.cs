﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    class Artikli
    {
        public int ID_artikla { get; set; }
        public string Naziv { get; set; }
        public int Cijena { get; set; }
        public int Kolicina { get; set; }
        public int ID_vrsta_artikla { get; set; }

        public void DohvatiID()
        {
            string q = "select ID_artikla from Artikli where Naziv='" + Naziv + "'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_artikla = int.Parse(dr[0].ToString());
            }
            dr.Close();
        }
        public int DodajArtikl()
        {
            string q = "insert into Artikli (Naziv,Cijena,Kolicina,ID_vrsta_artikla) values ('"+Naziv+"',"+Cijena+","+Kolicina+","+ID_vrsta_artikla+")";
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
        public void DohvatiIDNovogArtikla()
        {
            string q = "select top 1 * from Artikli order by ID_artikla desc";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_artikla = int.Parse(dr["ID_artikla"].ToString());
            }
            dr.Close();

        }
    }
}
