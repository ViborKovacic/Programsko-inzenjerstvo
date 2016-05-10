using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace PICvjecara
{
    class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private string connectionString;
        private SqlConnection connection;

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }

                return instance;
            }
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        private DatabaseConnection()
        {
            ConnectionString = "Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=16027_DB;Persist Security Info=True;User ID=16027_User;Password=uJYptMsf";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        ~DatabaseConnection()
        {
            Connection.Close();
            Connection = null;
        }

        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand comm = new SqlCommand(sqlUpit, Connection);
            return comm.ExecuteReader();
        }

        public object DohvatiVrijednosti(string sqlUpit)
        {
            SqlCommand comm = new SqlCommand(sqlUpit, Connection);
            return comm.ExecuteScalar();
        }

        public int IzvirsiUput(string sqlUpit)
        {
            SqlCommand comm = new SqlCommand(sqlUpit, Connection);
            return comm.ExecuteNonQuery();
        }
    }
}
