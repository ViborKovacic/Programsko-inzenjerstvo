﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
   public class Dobavljaci
    {
        public int ID_dobavljac { get; set; }
        public string Ime { get; set; }
        public string Telefon { get; set; }
        public string OIB { get; set; }
        public string Adresa { get; set; }

        public Dobavljaci()
        {
            
        }

        public void DohvatiDobavljace()
        {
            string q = "select * from Dobavljaci where Ime ='"+Ime+"'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);

            while(dr.Read())
            {
                ID_dobavljac = Convert.ToInt32( dr["ID_dobavljac"].ToString());
                Ime = dr["Ime"].ToString();
                OIB = dr["OIB"].ToString();
                Adresa = dr["Adresa"].ToString();


            }
            dr.Close();
            
        }
        public int DodajDobavljaca()
        {
            string q = "insert into Dobavljaci (Ime,OIB,Adresa,Telefon) values ('"+Ime+"','"+OIB+"','"+Adresa+"','"+Telefon+"')";
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
        public void DohvatiIDDobavljaca()
        {
            string q = "select top 1 * from Dobavljaci order by ID_dobavljac desc";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_dobavljac = int.Parse(dr["ID_dobavljac"].ToString());
            }
            dr.Close();
        }

        /*public List<string> DobavljaciUListu()
        {
            List<string> lista = new List<string>();
            string q = "select * from Dobavljaci where Ime='" + Ime + "'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                lista.Add(dr["Ime"].ToString());
                lista.Add(dr["OIB"].ToString());
                lista.Add(dr["Adresa"].ToString());

            }
            dr.Close();
            return lista;
        }*/



        


    }
}
