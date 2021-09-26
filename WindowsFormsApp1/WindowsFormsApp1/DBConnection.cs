using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DBConnection
    {
        public SqlConnection GetConnection()
        {
            string connectionstring = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=userdb;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connectionstring);
            return conn;
        }
    }
}
