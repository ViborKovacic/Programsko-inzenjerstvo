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
       

        public void CreateNarudzbenicaStaro(int ID_Dobavljac)
        {

            Datum_vrijeme = DateTime.Now;
            string format = "yyyy-MM-dd HH:MM:ss";
            ID_dobavljac = ID_Dobavljac;
            
            
            
            DatabaseConnection newConnection = new DatabaseConnection();
            newConnection.ConnectionDB();
            

            
            SqlCommand comm = new SqlCommand();
            comm.Connection = DatabaseConnection.conn;
            comm.CommandText = "insert into Narudzbenica (datum_vrijeme,ID_dobavljac,ID_korisnici) values ('"+Datum_vrijeme.ToString(format)+"',"+ID_dobavljac+","+Korisnici.ID_korisnik+")";
            comm.ExecuteNonQuery();

            DatabaseConnection.conn.Close();
            
        }
       
    }
}
