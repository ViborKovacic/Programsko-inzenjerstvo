using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara
{
    public class VrstaArtikla
    {
        static string vrsta;

        public string Vrsta
        {
            get
            {
                return vrsta;
            }

            set
            {
                if (vrsta != value)
                {
                    vrsta = value;
                }
            }
        }
        public VrstaArtikla()
        { }
            
        public VrstaArtikla(DbDataReader dr)
        {
            if (dr != null)
            {
                Vrsta = dr["Vrsta"].ToString();
            }
        }

        public static List<VrstaArtikla> DohvatiVrstuArtikla()
        {
            List<VrstaArtikla> lista = new List<VrstaArtikla>();
            string sqlUpit = "SELECT Vrsta FROM Vrsta_artikla";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                VrstaArtikla vrsta = new VrstaArtikla(dr);
                lista.Add(vrsta);
            }
            dr.Close();
            return lista;
        }
    }
}
