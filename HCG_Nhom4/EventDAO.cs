using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HCG_Nhom4
{
    public class EventDAO : AbstractDAO
    {
        private const string QueryGetAllData = "select *from dh_event";
        private const string QueryGetAllDataAndName = 
            "select e.id as id, e.content as content, c.id as categoryId from dh_event e join dh_category c on e.category_id = c.id";
        private const string QueryGetAllByKey = "select *from dh_event where id=@id";
        private const string QueryGetOnlyEventData = "select id, content from dh_event";
        private const string QueryGetDataByCategoryId = "select id, conent from dh_event where category_id=@categoryId";
        private const string QueryInsertEvent = "insert into dh_event values (@id, @content, @categoryId)";

        private const string QueryUpdateEvent =
            "update dh_event set content=@content, category_id=@categoryId where id=@id";

        private const string QueryDelete = "delete from dh_event where id = @id";

        private const string QueryLoadData =
            "select e.id as id, e.content as content, c.name as name from dh_event e join dh_category c on e.category_id = c.id where c.name != @name";

        private const string QueryLoadContentByCategory =
            "select id,content from dh_event where category_id = (select id from dh_category where name = @name)";


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
        
        public DataTable GetDisplayData()
        {
            return FetchData(QueryGetAllDataAndName, null);
        }

        public DataTable LoadData()
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("name", "Ngành");
            return FetchData(QueryLoadData, parameters);
        }

        public DataTable GetDataByKey(string id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            return FetchData(QueryGetAllByKey, parameters);
        }

        public DataTable GetOnlyEventData()
        {
            return FetchData(QueryGetOnlyEventData, null);
        }

        public DataTable GetDataByCategoryId(string id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("categoryId", id);
            return FetchData(QueryGetDataByCategoryId, parameters);
        }

        public DataTable GetDataByCategoryName(string content)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("name", content);
            return FetchData(QueryLoadContentByCategory, parameters);
        }

        public void Insert(string id, string content, string categoryId)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            parameters.Add("content", content);
            parameters.Add("categoryId", categoryId);
            ExecuteNonQuery(QueryInsertEvent, parameters);
        }

        public void Update(string id, string content, string categoryId)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            parameters.Add("content", content);
            parameters.Add("categoryId", categoryId);
            ExecuteNonQuery(QueryUpdateEvent, parameters);
        }

        public void Delete(string id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            ExecuteNonQuery(QueryDelete, parameters);
        }
    }
}