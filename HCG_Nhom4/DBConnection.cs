using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_Nhom4
{
    public class DBConnection
    {
        public SqlConnection GetConnect()
        {
            String connString = @"Data Source=DINHTHANH-PC\SQLEXPRESS;Initial Catalog=HCG_Nhom10;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public DataTable GetTable(String sql)
        {
            SqlConnection con = GetConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void ExecuteNonQuery(String sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
