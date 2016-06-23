using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.ComponentModel;

namespace PICvjecara.DBClass
{
    public class Dobavljac
    {
        public int ID_dobavljac { get; set; }
        public string Ime { get; set; }
        public string Telefon { get; set; }
        public string OIB { get; set; }
        public string Adresa { get; set; }
        
       public static  BindingList<Dobavljac> listaDobavljaca = new BindingList<Dobavljac>();
       



        public Dobavljac()
        {

        }

        public void DohvatiDobavljace(int IdDobavljaca)
        {
            string q = "select * from Dobavljaci where ID_dobavljac ='" + IdDobavljaca + "'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);

            while (dr.Read())
            {
                ID_dobavljac = int.Parse(dr["ID_dobavljac"].ToString());
                Ime = dr["Ime"].ToString();
                OIB = dr["OIB"].ToString();
                Adresa = dr["Adresa"].ToString();
                Telefon = dr["Telefon"].ToString();


            }
            dr.Close();

        }
       public BindingList<Dobavljac> ListaDobavljaca(Dobavljac dobavljac)
        {

           
            listaDobavljaca.Add(dobavljac);
            return listaDobavljaca;
        }
       /*public void DohvatiImeDobavljace(string ime)
         {
             string q = "select * from Dobavljaci where Ime ='" + ime + "'";
             DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);

             while (dr.Read())
             {
                 
                 Ime = dr["Ime"].ToString();
                 


             }
             dr.Close();

         }*/
        public int DodajDobavljaca()
        {
            string q = "insert into Dobavljaci (Ime,OIB,Adresa,Telefon) values ('" + Ime + "','" + OIB + "','" + Adresa + "','" + Telefon + "')";
            return DatabaseConnection.Instance.IzvirsiUput(q);
        }
        /*public  DohvatiIDDobavljaca()
        {
            string q = "select top 1 * from Dobavljaci order by ID_dobavljac desc";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_dobavljac = int.Parse(dr["ID_dobavljac"].ToString());
            }
            dr.Close();
        }*/







    }
}
