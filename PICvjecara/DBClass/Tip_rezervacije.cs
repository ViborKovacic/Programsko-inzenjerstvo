using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    public class Tip_rezervacije
    {
        public int ID_tip_rezervacije { get; set; }
        public string Vrsta { get; set; }

        public int broj { get; set; }

        public int DodajVrstuRezervacije()
        {
            string q = "insert into Tip_rezervacije (Vrsta) values ('" + Vrsta + "')";
            return DatabaseConnection.Instance.IzvirsiUput(q);
            
        }
        public void DohvatiIzBaze()
        {
            string q = "select * from Tip_rezervacije where Vrsta='"+Vrsta+"'";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_tip_rezervacije = int.Parse(dr["ID_tip_rezervacije"].ToString());
                
            }
            dr.Close();
        }
        public void DohvatiIdVrsteRez()
        {
            string q = "select top 1 * from Tip_rezervacije order by ID_tip_rezervacije desc ";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {
                ID_tip_rezervacije = int.Parse(dr["ID_tip_rezervacije"].ToString());
            }
            dr.Close();
        }
        public void DohvatiIzBazeVrsta()
        {

            string q = "select count(*) as 'broj' from Tip_rezervacije tv where tv.Vrsta ='" +Vrsta + "' group by  tv.Vrsta";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(q);
            while (dr.Read())
            {

                broj = int.Parse(dr["broj"].ToString());
            }
            dr.Close();

        }
    }
}
