using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HCG_Nhom4
{
    public abstract class AbstractDAO
    {
        public abstract DataTable GetAllData();

        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (var connection = ConnectionProvider.getConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    var sqlCommand = new SqlCommand(query, connection);
                    if (parameters != null && parameters.Any())
                    {
                        foreach (var entry in parameters)
                        {
                            sqlCommand.Parameters.AddWithValue("@" + entry.Key, entry.Value);
                        }
                    }

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public DataTable FetchData(string query, Dictionary<string, object> parameters)
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

                    var sqlCommand = new SqlCommand(query, connection);
                    result = new DataTable();
                    if (parameters != null && parameters.Any())
                    {
                        foreach (var entry in parameters)
                        {
                            sqlCommand.Parameters.AddWithValue("@" + entry.Key, entry.Value);
                        }
                    }

                    var sqlDataReader = sqlCommand.ExecuteReader();
                    result.Load(sqlDataReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }
    }
}