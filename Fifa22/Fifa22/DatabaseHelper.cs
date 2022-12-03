using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa22
{
    public class DatabaseHelper
    {
        static string connectionString = "Server=localhost;Database=Fifa22;Trusted_Connection=True;";
        public static DataTable ExecuteQuery(string query)
        {

            DataTable dataTable = new DataTable();

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            try
            {
                da.Fill(dataTable);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!");
            }
            conn.Close();
            da.Dispose();
            return dataTable;
        }
        
    }
}
