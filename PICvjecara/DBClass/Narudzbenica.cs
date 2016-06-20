﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
   public  class Narudzbenica
    {
        private string datumFormat = "yyyy-MM-dd HH:MM:ss";
        public int ID_narudzbenica { get; set; }
        public DateTime Datum_vrijeme { get; set; }
        public int ID_dobavljac { get; set; }
        public int ID_korisnici { get; set; }
        public int kolicina { get; set; }
        public string Naziv { get; set; }
        
       

        public Narudzbenica()
        {
            
        }
        public void DohvatiImeNarudzbenice(string naziv)
        {
            string q = "select Naziv from Narudzbenica where Naziv='" + naziv + "'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while(dr.Read())
            {
                Naziv = dr["Naziv"].ToString();
            }
            dr.Close();
        }
        public int Spremi()
        {
            string q = "insert into Narudzbenica (datum_vrijeme,ID_dobavljac,ID_korisnici,kolicina,Naziv) values ('" + Datum_vrijeme.ToString(datumFormat) 
                + "',"+ID_dobavljac
                +","+ID_korisnici
                +","+kolicina
                +",'" + Naziv + "')";


            return DatabaseConnection.Instance.IzvirsiUput(q);  
        }

        public void DohvatiIDNaruzbe()
        {
            string q = "select top 1 * from Narudzbenica order by ID_narudzbenice desc ";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_narudzbenica = int.Parse(dr["ID_narudzbenice"].ToString());
            }
            dr.Close();
        }
        
        public int Brisi(int IDBrisi)
        {
            string q = "delete from Narudzbenica where ID_narudzbenice=" + IDBrisi;
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }

      

    }
    
}
