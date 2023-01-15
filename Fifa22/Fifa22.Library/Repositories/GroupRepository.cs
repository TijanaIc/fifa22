using Fifa22.Library.Resources;
using System.Data;

namespace Fifa22.Library.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public DatabaseHelper DatabaseConnection { get; }

        public GroupRepository(DatabaseHelper databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();
            string query = DatabaseQueries.GROUP_LIST;
            DataTable tableGroups = DatabaseConnection.ExecuteQuery(query);
            foreach (DataRow row in tableGroups.Rows)
            {
                var g = new Group();
                g.Name = row["Team_group"].ToString();
                groups.Add(g);
            }

            return groups;
        }
    }
}
