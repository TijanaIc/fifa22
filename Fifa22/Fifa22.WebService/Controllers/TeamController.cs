using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        [HttpGet("list")]
        public List<Team> Get()
        {
            List<Team> team = new List<Team>();
            DataTable teams = DatabaseHelper.ExecuteQuery("select Team_name from Team");
            foreach (DataRow teamRow in teams.Rows)
            {
                var t = new Team();
                t.Team_name = teamRow["Team_name"].ToString();
                team.Add(t);
            }
            return team;
        }
        [HttpGet("search-by-group/{groupName}")]
        public List<Team> GetTeams(string groupName)
        {
            List<Team> team = new List<Team>();
            DataTable teams = DatabaseHelper.ExecuteQuery($"select * from Team where Team_group='{groupName}'");
            foreach (DataRow teamRow in teams.Rows)
            {
                var t = new Team();
                t.Team_name = teamRow["Team_name"].ToString();
                t.Team_id = Convert.ToInt32(teamRow["Team_id"]);
                t.Team_group = teamRow["Team_group"].ToString();
                team.Add(t);
            }
            return team;
        }

        [HttpGet("search-by-id/{teamId}")]
        public Team GetTeam(int teamId)
        {
            DataTable teams = DatabaseHelper.ExecuteQuery($"select * from Team where Team_id='{teamId}'");
            foreach (DataRow teamRow in teams.Rows)
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
            DataTable teams = DatabaseHelper.ExecuteQuery($"select top {top} Teamid as Team_id,sum(GoalCount) as TeamsGoals from Player group by Teamid order by TeamsGoals desc;");
            foreach (DataRow playerRow in teams.Rows)
            {
                var gt = new TeamEx();
                gt.Team_id = Convert.ToInt32(playerRow["Team_id"]);
                gt.GoalCount= Convert.ToInt32(playerRow["TeamsGoals"]);
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




