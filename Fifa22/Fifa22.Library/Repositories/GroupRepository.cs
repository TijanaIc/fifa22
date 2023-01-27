using Fifa22.Library.Resources;
using System.Data;

namespace Fifa22.Library.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public IDbConnection DatabaseConnection { get; }

        public GroupRepository(IDbConnection databaseConnection)
        {
            //test
            //tijana's change 1
            DatabaseConnection = databaseConnection;
        }

        public List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();
            string query = GroupQueries.GROUP_LIST;
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
