using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BarcodePrint
{
    internal class DatabaseConnection
    {
        private static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LSBUDBConnection"].ConnectionString);
                    _connection.Open();
                }
                return _connection;
            }
        }
    }
}
