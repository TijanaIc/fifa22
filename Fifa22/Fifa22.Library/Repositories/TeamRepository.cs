using Fifa22.Library.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa22.Library.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public DatabaseHelper DatabaseConnection { get; }

        public TeamRepository(DatabaseHelper databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<Team> GetTeams()
        {
            List<Team> team = new List<Team>();
            string query = TeamQueries.TEAM_LIST;
            DataTable teams = DatabaseConnection.ExecuteQuery(query);
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
            string query = string.Format(TeamQueries.GET_TEAM_BY_NAME, groupName);
            DataTable tableTeam = DatabaseConnection.ExecuteQuery(query);
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
            string query = string.Format(TeamQueries.GET_TEAM_BY_ID, teamId);
            DataTable tableTeam = DatabaseConnection.ExecuteQuery(query);
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
            string query = string.Format(TeamQueries.GET_TEAM_BY_GOAL, top);
            DataTable teams = DatabaseConnection.ExecuteQuery(query);
            foreach (DataRow playerRow in teams.Rows)
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
    }
}
