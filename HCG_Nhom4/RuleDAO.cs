using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HCG_Nhom4
{
    public class RuleDAO : AbstractDAO
    {
        private const string QueryGetAllData = "select id, content from dh_rule";
        private const string QueryAllRuleContent = "select content from dh_rule";
        private const string QueryAllRuleByKey = "select *from dh_rule where id=@id";
        private const string QueryInsertRule = "insert into dh_rule(id,name) values (@id, @content)";
        private const string QueryUpdateRule = "update dh_rule set content=@content where id=@id";
        private const string QueryDeleteRule = "delete from dh_rule where id=@id";

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

        public DataTable GetAllContent()
        {
            return FetchData(QueryAllRuleContent, null);
        }

        public DataTable GetDataByKey(string id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            return FetchData(QueryAllRuleByKey, parameters);
        }

        public void Insert(string id, string content)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            parameters.Add("content", content);
            ExecuteNonQuery(QueryInsertRule, parameters);
        }

        public void Update(string id, string content)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            parameters.Add("content", content);
            ExecuteNonQuery(QueryUpdateRule, parameters);
        }

        public void Delete(string id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            ExecuteNonQuery(QueryDeleteRule, parameters);
        }
    }
}