using System.Data;

namespace Fifa22.Library
{
    public class DatabaseReader : IDataReader
    {
        public List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();
            DataTable tableGroups = DatabaseHelper.ExecuteQuery("select distinct Team_group from Team");
            foreach (DataRow row in tableGroups.Rows)
            {
                var g = new Group();
                g.Name = row["Team_group"].ToString();
                groups.Add(g);
            }

            return groups;
        }

        public List<Team> GetTeam(string groupName)
        {
            List<Team> teams = new List<Team>();
            DataTable tableTeam = DatabaseHelper.ExecuteQuery($"select Team_name, Team_group, Team_id from Team where Team_group = '{groupName}'");
            foreach (DataRow row in tableTeam.Rows)
            {
                var t = new Team();
                t.Team_name = row["Team_name"].ToString();
                t.Team_group = row["Team_group"].ToString();
                t.Team_id = Convert.ToInt32(row["Team_id"]);             
                teams.Add(t);
            }

            return teams;
        }

        public List<Player> GetPlayersFromTeam(int teamId)
        {
            List<Player> players = new List<Player>();
            DataTable tablePlayers = DatabaseHelper.ExecuteQuery($"select FirstName, LastName from Player where TeamId = '{teamId}'");
            foreach (DataRow row in tablePlayers.Rows)
            {
                var p = new Player();
                p.FirstName = row["FirstName"].ToString();
                p.LastName = row["LastName"].ToString();
                players.Add(p);
            }
            return players;
        }
    }
}
