using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    class DBSQLSeverUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database, string username) {
            // "Data Source=DESKTOP-3KQBP24\\VUKHA;Initial Catalog=QLNS;Integrated Security=True";
            string connString = @"Data Source="+datasource+ ";Initial Catalog="+database+";Integrated Security ="+username;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
