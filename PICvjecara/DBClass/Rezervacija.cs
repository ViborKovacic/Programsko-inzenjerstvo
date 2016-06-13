﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    public class Rezervacija
    {
        public int ID_rezervacije { get; set; }
        public float Cijena { get; set; }    
        public int ID_tip_rezervacije { get; set; }
        public string Opis { get; set; }

        public void DohvatiIzBaze()
        {
            string q = "select * from Rezervacija where ID_tip_rezervacije =" + ID_tip_rezervacije + "";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_rezervacije = int.Parse(dr["ID_rezervacije"].ToString());
                Cijena = float.Parse(dr["Cijena"].ToString());
                //Kolicina = int.Parse(dr["Kolicina"].ToString());
                Opis = dr["Opis"].ToString();
            }
            dr.Close();
        }
        public int Insert()
        {
            string q = "insert into Rezervacija (Cijena,ID_tip_rezervacije,Opis) values ("+Cijena+","+ID_tip_rezervacije+",'"+Opis+"')";
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
        public void DohvatiIdRezervacije()
        {
            string q = "select top 1 * from Rezervacija order by ID_rezervacije desc";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while(dr.Read())
            {
                ID_rezervacije = int.Parse(dr["ID_rezervacije"].ToString());
            }
            dr.Close();
        }
    }
}
