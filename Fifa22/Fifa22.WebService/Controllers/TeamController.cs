using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        public IDataReader DataReader { get; }
        public DatabaseHelper DatabaseHelper { get; }

        public TeamController(IDataReader dataReader, DatabaseHelper databaseHelper)
        {
            DataReader = dataReader;
            DatabaseHelper = databaseHelper;
        }

        [HttpGet("list")]
        public List<Team> Get()
        {
            var teams = DataReader.GetTeams();
            return teams;
        }

        [HttpGet("search-by-group/{groupName}")]
        public List<Team> GetTeams(string groupName)
        {
            var teams = DataReader.GetTeamByName(groupName);
            return teams;
        }

        [HttpGet("search-by-id/{teamId}")]
        public List<Team> GetTeamById(int teamId)
        {
            var teams = DataReader.GetTeamById(teamId);
            return teams;
        }

        [HttpGet("search-by-goals/{top}")]
        public List<TeamEx> GetTeamByGoal(int top)
        {
            var teams = DataReader.GetTeamByGoal(top);
            return teams;
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




