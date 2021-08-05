using System.Data.SqlClient;

namespace HCG_Nhom4
{
    public class ConnectionProvider
    {
        private const string ConnectionString =
            @"Server=172.30.0.1;Database=hcg_4;User=sa;Password=thaind123!@#;MultipleActiveResultSets=true;";

        public static SqlConnection getConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            return connection;
        }
    }
}