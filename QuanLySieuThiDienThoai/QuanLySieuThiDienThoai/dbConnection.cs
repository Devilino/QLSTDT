using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLySieuThiDienThoai
{
    class dbConnection
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;

        public dbConnection()
        {
            myAdapter = new SqlDataAdapter();
            conn = new SqlConnection(@"Data Source=XUANTHU;Initial Catalog=Thi;Integrated Security=True");
        }

        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
