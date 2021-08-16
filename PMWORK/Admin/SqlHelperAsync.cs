using System.Data;
using System.Data.SqlClient;

namespace PMWORK.Admin
{
    public   class SqlHelperAsync
    {
        private  SqlConnection _sqlConnection;
        public  bool IsConnectionAsync(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            if (_sqlConnection.State == ConnectionState.Closed) 
            {
                _sqlConnection.Open();
            }
            return true;
        }
    }
}
