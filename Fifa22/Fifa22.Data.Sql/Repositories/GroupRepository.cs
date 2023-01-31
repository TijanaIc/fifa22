using Fifa22.Data.Sql.Resources;
using System.Data;
using Fifa22.Data.Repositories;

namespace Fifa22.Data.Sql.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public IDbConnection DatabaseConnection { get; }

        public GroupRepository(IDbConnection databaseConnection)
        {
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
