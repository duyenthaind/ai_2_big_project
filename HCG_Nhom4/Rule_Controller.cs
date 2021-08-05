using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_Nhom4
{
    public class Rule_Controller
    {
        DBConnection kn = new DBConnection();
        public DataTable getData()
        {
            string sql = "select * from tapluat";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public DataTable getnoidung()
        {
            string sql = "select noidung from tapluat";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public DataTable timkiem(String key)
        {
            string sql = "select * from tapluat where maluat = '" + key + "'";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public void Insert(String maluat, String noidung)
        {
            string sql = "insert into tapluat  values('" + maluat + "',N'" + noidung + "')";
            kn.ExecuteNonQuery(sql);
        }
        public void Update(String maluat, String noidung)
        {
            string sql = "update tapluat set noidung = N'" + noidung + "' where maluat='" + maluat + "'";
            kn.ExecuteNonQuery(sql);
        }
        public void Delete(String maluat)
        {
            string sql = "delete tapluat where maluat='" + maluat + "'";
            kn.ExecuteNonQuery(sql);
        }

    }
}

