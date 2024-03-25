using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection() {

            //Data Source=DESKTOP-3KQBP24\VUKHA;Initial Catalog=QLNS;Integrated Security=True

            //Data Source=UNKNOWHOST134\MSSQL;Initial Catalog=QLNS;Integrated Security=True

            string datasource = @"UNKNOWHOST134\MSSQL";
            string database = "QLNS";
            string username = "True";
            return DBSQLSeverUtils.GetDBConnection(datasource, database, username);
        }
    }
}
