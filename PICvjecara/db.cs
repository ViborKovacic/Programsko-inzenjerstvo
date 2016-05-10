using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PICvjecara
{
    public class db
    {
       public SqlConnection conn = new SqlConnection("Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=16027_DB;Persist Security Info=True;User ID=16027_User;Password=uJYptMsf");
      // public SqlCommand comm;
       //public SqlDataReader dr;
        public void OpenCon()
        {
            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();
            //}
        }
        public void CloseCon()
        {
            //if (conn.State == ConnectionState.Open)
            //{
            //    conn.Close();
            //}
        }
    }
}
