using System.Data;
using Fifa22.Library.Resources;

namespace Fifa22.Library
{
    public class DatabaseReader : IDataReader
    {
        public DatabaseHelper DatabaseHelper { get; }

        public DatabaseReader(DatabaseHelper databaseHelper)
        {
            DatabaseHelper = databaseHelper;
        }

        public List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();
            string query = DatabaseQueries.GROUP_LIST;
            DataTable tableGroups = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in tableGroups.Rows)
            {
                var g = new Group();
                g.Name = row["Team_group"].ToString();
                groups.Add(g);
            }

            return groups;
        }
        public List<Team> GetTeams()
        {
            List<Team> team = new List<Team>();
            string query = TeamQueries.TEAM_LIST;
            DataTable teams = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow teamRow in teams.Rows)
            {
                var t = new Team();
                t.Team_name = teamRow["Team_name"].ToString();
                t.Team_group = teamRow["Team_group"].ToString();
                t.Team_id = Convert.ToInt32(teamRow["Team_id"]);
                team.Add(t);
            }
            return team;
        }

        public List<Team> GetTeamByName(string groupName)
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

        public List<Team> GetTeamById(int teamId)
        {
            List<Team> teams = new List<Team>();
            DataTable tableTeam = DatabaseHelper.ExecuteQuery($"select Team_name, Team_group, Team_id from Team where Team_id = '{teamId}'");
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

        public List<TeamEx> GetTeamByGoal(int top)
        {
            List<TeamEx> teamsList = new List<TeamEx>();
            System.Data.DataTable teams = DatabaseHelper.ExecuteQuery($"select top {top} Teamid as Team_id, sum(GoalCount) as TeamsGoals, Team_name, Team_group from PlayerEx group by Teamid, Team_name, Team_group  order by TeamsGoals desc");
            foreach (System.Data.DataRow playerRow in teams.Rows)
            {
                var gt = new TeamEx();
                gt.Team_id = Convert.ToInt32(playerRow["Team_id"]);
                gt.GoalCount = Convert.ToInt32(playerRow["TeamsGoals"]);
                gt.Team_name = playerRow["Team_name"].ToString();
                gt.Team_group = playerRow["Team_group"].ToString();
                teamsList.Add(gt);
            }
            return teamsList;
        }

        public List<Player> GetPlayers()
        {
            List<Player> player = new List<Player>();
            System.Data.DataTable players = DatabaseHelper.ExecuteQuery($"select * from Player");
            foreach (System.Data.DataRow playerRow in players.Rows)
            {
                var p = new Player();
                p.PlayerId = Convert.ToInt32(playerRow["PlayerId"]);
                p.FirstName = playerRow["FirstName"].ToString();
                p.LastName = playerRow["LastName"].ToString();
                p.GoalCount = Convert.ToInt32(playerRow["GoalCount"]);
                p.TeamId = Convert.ToInt32(playerRow["TeamId"]);

                player.Add(p);
            }
            return player;
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
