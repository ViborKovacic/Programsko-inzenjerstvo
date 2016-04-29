using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBOperacije
{
    class OperacijeNarudzba: DBClass.Narudzbenica
    {
       

        public void CreateNarudzbenicaStaro(int ID_Dobavljac, int ID_Korisnici)
        {

            Datum_vrijeme = DateTime.Now;
            ID_dobavljac = ID_Dobavljac;
            ID_korisnici = ID_Korisnici;

            
            DatabaseConnection newConnection = new DatabaseConnection();
            newConnection.ConnectionDB();
            

            
            SqlCommand comm = new SqlCommand();
            comm.Connection = DatabaseConnection.conn;
            comm.CommandText = "insert into Narudzbenica (datum_vrijeme,ID_dobavljac,ID_korisnik) values ('"+Datum_vrijeme+"',"+ID_dobavljac+","+ID_korisnici+")";
            comm.ExecuteNonQuery();

            DatabaseConnection.conn.Close();
            
        }
    }
}
