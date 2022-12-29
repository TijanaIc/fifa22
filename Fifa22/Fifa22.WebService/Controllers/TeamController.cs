using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        public IDataReader DataReader { get; }

        public TeamController(IDataReader dataReader)
        {
            DataReader = dataReader;
        }

        [HttpGet("list")]
        public List<Team> Get()
        {
            List<Team> team = new List<Team>();
            System.Data.DataTable teams = DatabaseHelper.ExecuteQuery("select Team_name, Team_group, Team_id from Team");
            foreach (System.Data.DataRow teamRow in teams.Rows)
            {
                var t = new Team();
                t.Team_name = teamRow["Team_name"].ToString();
                t.Team_group = teamRow["Team_group"].ToString();
                t.Team_id = Convert.ToInt32(teamRow["Team_id"]);
                team.Add(t);
            }
            return team;
        }

        [HttpGet("search-by-group/{groupName}")]
        public List<Team> GetTeams(string groupName)
        {
            var teams = DataReader.GetTeam(groupName);
            return teams;
        }

        [HttpGet("search-by-id/{teamId}")]
        public Team GetTeam(int teamId)
        {
            System.Data.DataTable teams = DatabaseHelper.ExecuteQuery($"select * from Team where Team_id='{teamId}'");
            foreach (System.Data.DataRow teamRow in teams.Rows)
            {
                var t = new Team();
                t.Team_name = teamRow["Team_name"].ToString();
                t.Team_id = Convert.ToInt32(teamRow["Team_id"]);
                t.Team_group = teamRow["Team_group"].ToString();
                return t;
            }
            return null;
        }

        [HttpGet("search-by-goals/{top}")]
        public List<TeamEx> GetGoalsCount(int top)
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

        [HttpDelete("delete-by-id/{team_id}")]
        public void DeleteTeam(int team_id)
        {
            DatabaseHelper.ExecuteQuery($"delete from Player where TeamId = '{team_id}'");
            DatabaseHelper.ExecuteQuery($"delete from Team where Team_id = '{team_id}'");
        }

        [HttpPut("update-by-id")]
        public void UpdateTeam(Team team)
        {
            DatabaseHelper.ExecuteQuery($"UPDATE Team SET Team_name = '{team.Team_name}', Team_group = '{team.Team_group}' where Team_id = '{team.Team_id}'");
        }

        [HttpPost("insert")]
        public void InsertTeam(Team team)
        {
            DatabaseHelper.ExecuteQuery($"INSERT INTO Team VALUES ('{team.Team_name}', '{team.Team_group}')");
        }
    }
}




