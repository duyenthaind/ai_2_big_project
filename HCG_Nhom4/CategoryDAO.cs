using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HCG_Nhom4
{
    public class CategoryDAO : AbstractDAO
    {
        private const string QueryGetAllData = "select *from dh_category";
        private const string QueryGetIdByContent = "select id from dh_category where content = @content";

        public override DataTable GetAllData()
        {
            DataTable result = null;
            using (var connection = ConnectionProvider.getConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    var sqlAdapter = new SqlDataAdapter(QueryGetAllData, connection);
                    result = new DataTable();
                    sqlAdapter.Fill(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }

        public string GetCategoryIdByContent(string content)
        {
            string id = null;
            var connection = ConnectionProvider.getConnection();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
                var sqlCommand = new SqlCommand(QueryGetIdByContent, connection);
                sqlCommand.Parameters.AddWithValue("@content", content);
                var sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    var stringObject = sqlReader[0].ToString();
                    if (stringObject != null && stringObject != "")
                    {
                        id = stringObject;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return id;
        }
    }
}