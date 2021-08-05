using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_Nhom4
{
    public class Event_Controller
    {
        DBConnection kn = new DBConnection();
        public DataTable getData()
        {
            string sql = "select * from sukien";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public DataTable loadDuLieu()
        {
            string sql = "select * from sukien where nhomsukien <> N'Ngành' ";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public DataTable timkiem(String key)
        {
            string sql = "select * from sukien where masukien = '" + key + "' ";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public DataTable getSukien()
        {
            string sql = "select masukien, noidung from sukien";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public DataTable getNganh()
        {
            string sql = "select masukien, noidung from sukien where nhomsukien =N'Ngành'";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public void Insert(String masukien, String noidung, String loaisk)
        {
            string sql = "insert into sukien  values('" + masukien + "',N'" + noidung + "',N'" + loaisk + "')";
            kn.ExecuteNonQuery(sql);
        }
        public void Update(String masukien, String noidung, String loaisk)
        {
            string sql = "update sukien set noidung = N'" + noidung + "', nhomsukien = N'" + loaisk + "' where masukien='" + masukien + "'";
            kn.ExecuteNonQuery(sql);
        }
        public void Delete(String msk)
        {
            string sql = "delete sukien where masukien='" + msk + "'";
            kn.ExecuteNonQuery(sql);
        }
    }
}

