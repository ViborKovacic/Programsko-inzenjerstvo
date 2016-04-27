using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PICvjecara
{
    class DatabaseConnection
    {
        public static SqlConnection conn = null;

        public void ConnectionDB()
        {
            conn = new SqlConnection("Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=16027_DB;Persist Security Info=True;User ID=16027_User;Password=uJYptMsf");
            conn.Open();
        }
    }
}
