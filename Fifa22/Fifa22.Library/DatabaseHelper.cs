using System.Data;
using System.Data.SqlClient;

namespace Fifa22.Library
{
    public class DatabaseHelper
    {
        static string connectionString = @"Server=localhost;Database=Fifa22;Trusted_Connection=True;";
        public static DataTable ExecuteQuery(string query)
        {

            DataTable dataTable = new DataTable();           
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                conn.Close();
                da.Dispose();

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
            
            return dataTable;
        }
        
    }
}
