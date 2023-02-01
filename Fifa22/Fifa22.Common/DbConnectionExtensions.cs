using System.Data;

namespace Fifa22.Common
{
    public static class DbConnectionExtensions
    {
        public static DataTable ExecuteQuery(this IDbConnection dbConnection, string query)
        {
            DataTable dataTable = new DataTable();

            IDbCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = query;
            dbConnection.Open();
            IDataReader dr = cmd.ExecuteReader();
            dataTable.Load(dr);
            dbConnection.Close();

            return dataTable;
        }
    }
}
