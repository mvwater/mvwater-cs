using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace mvwater_netfw
{
    class dbDropConnection
    {
        public void dropConnection()
        {
            SqlConnection cnn;
            string connectionString = null;
            cnn = new SqlConnection(connectionString);
            cnn.Close();
        }
    }
}
