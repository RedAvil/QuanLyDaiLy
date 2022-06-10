using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_QuanLyDaiLy
{
    class DBSqlServerUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string connString = @"Data Source=DESKTOP-KIETDT\SQLEXPRESS;Initial Catalog=QuanLyDaiLy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
