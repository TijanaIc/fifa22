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
    }
}





