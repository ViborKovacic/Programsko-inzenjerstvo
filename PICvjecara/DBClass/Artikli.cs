using System;
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
        public decimal Cijena { get; set; }
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
                Cijena = decimal.Parse(dr["Cijena"].ToString());
                Kolicina = Convert.ToInt32(dr["Kolicina"].ToString());
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
    }
}
