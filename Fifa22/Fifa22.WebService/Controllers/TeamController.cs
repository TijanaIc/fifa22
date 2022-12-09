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
        public List<TeamStats> GetGoalsCount(int top)
        {
            List<TeamStats> teamsList = new List<TeamStats>();
            DataTable teams = DatabaseHelper.ExecuteQuery($"select top {top} Teamid as Team_id,sum(GoalCount) as TeamsGoals from Player group by Teamid order by TeamsGoals desc;");
            foreach (DataRow playerRow in teams.Rows)
            {
                var gt = new TeamStats();
                gt.Team_id = Convert.ToInt32(playerRow["Team_id"]);
                gt.GoalCount= Convert.ToInt32(playerRow["TeamsGoals"]);
                teamsList.Add(gt);
            }
            return teamsList;
        }
    }
}




