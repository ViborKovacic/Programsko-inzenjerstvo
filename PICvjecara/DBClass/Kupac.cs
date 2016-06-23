using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.ComponentModel;

namespace PICvjecara.DBClass
{
    public class Kupac
    {
        public int ID_kupca { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string OIB { get; set; }

        public int broj = 0;
        public static BindingList<Kupac> listaKlijenta = new BindingList<Kupac>();


        public void DohvatiKlijenta(int iDKlijenta)
        {
            string q = "select ID_kupca as 'Broj Kupca', Ime,Prezime,OIB,Adresa,Email,Telefon from Kupci where ID_kupca="+iDKlijenta;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_kupca = iDKlijenta;
                Ime = dr["Ime"].ToString();
                Prezime = dr["Prezime"].ToString();
                Adresa = dr["Adresa"].ToString();
                Email = dr["Email"].ToString();
                OIB = dr["OIB"].ToString();
                Telefon = dr["Telefon"].ToString();
            }
            dr.Close();
        }
        public void DohvatiIzBazeOIB()
        {
            
                string q = "select *, count(*) as 'broj' from Kupci k where k.OIB ='"+OIB+"' group by  k.ID_kupca,k.Ime,k.Prezime,k.Adresa,k.Email,k.Telefon, k.OIB";
                DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
                while (dr.Read())
                {
                    ID_kupca = int.Parse(dr["ID_kupca"].ToString());
                    Ime = dr["Ime"].ToString();
                    Prezime = dr["Prezime"].ToString();
                    Adresa = dr["Adresa"].ToString();
                    Email = dr["Email"].ToString();
                    Telefon = dr["Telefon"].ToString();
                    broj = int.Parse(dr["broj"].ToString());
                }
                dr.Close();
                
            
           

        }
       /* public void DohvatiID()
        {
            string q = "select top 1 * from Kupci order by ID_kupca desc";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_kupca = int.Parse(dr["ID_kupca"].ToString());
                
            }
            dr.Close();
        }*/
        public int Insert()
        {
            string q = "insert into Kupci (Ime,Prezime,Adresa,Email,Telefon,OIB) values ('"+Ime
                +"','"+Prezime
                + "','" + Adresa
                + "','" + Email
                + "','" + Telefon
                + "','" + OIB+"')";
            return DatabaseConnection.Instance.IzvirsiUput(q);


        }

        
        public int Update()
        {
            string q = "UPDATE Kupci SET Ime='"+Ime
                + "', Prezime = '" + Prezime
                + "', Adresa = '" + Adresa
                + "', Email = '" + Email
                + "', Telefon = '" + Telefon
                + "' WHERE ID_kupca="+ID_kupca;
            return DatabaseConnection.Instance.IzvirsiUput(q);

        }
        public BindingList<Kupac> ListaKlijenta(Kupac klijent)
        {


            listaKlijenta.Add(klijent);
            return listaKlijenta;
        }

    }
}
