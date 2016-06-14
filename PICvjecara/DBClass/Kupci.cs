using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    public class Kupci
    {
        public int ID_kupca { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string OIB { get; set; }

        public int broj = 0;

        public void DohvatiIzBaze()
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
        public void DohvatiID()
        {
            string q = "select top 1 * from Kupci order by ID_kupca desc";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_kupca = int.Parse(dr["ID_kupca"].ToString());
                
            }
            dr.Close();
        }
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

        public void BrisiSadrzajClasse()
        {
            ID_kupca = 0;
            Ime = null;
            Prezime = null; 
            Adresa = null;
            Email = null;
            Telefon = null;
            OIB = null;
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
        
    }
}
