using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Fifa22.Library
{
    public class DatabaseHelper
    {
        string ConnectionString { get; set; }
        public DatabaseHelper(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("FifaDatabase");
        }

        public DataTable ExecuteQuery(string query)
        {

            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            return dataTable;
        }
        
    }
}
