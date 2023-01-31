using Fifa22.Data;
using Fifa22.Data.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        public ITeamRepository TeamRepository { get; }

        public TeamController(ITeamRepository teamRepository)
        {
            TeamRepository = teamRepository;
        }

        [HttpGet("list")]
        public List<Team> Get()
        {
            var teams = TeamRepository.GetTeams();
            return teams;
        }

        [HttpGet("search-by-group/{groupName}")]
        public List<Team> GetTeams(string groupName)
        {
            var teams = TeamRepository.GetTeamByName(groupName);
            return teams;
        }

        [HttpGet("search-by-id/{teamId}")]
        public List<Team> GetTeamById(int teamId)
        {
            var teams = TeamRepository.GetTeamById(teamId);
            return teams;
        }

        [HttpGet("search-by-goals/{top}")]
        public List<TeamEx> GetTeamByGoal(int top)
        {
            var teams = TeamRepository.GetTeamByGoal(top);
            return teams;
        }

        [HttpDelete("delete-by-id/{team_id}")]
        public void DeleteTeam(int team_id)
        {
            TeamRepository.DeleteTeam(team_id);
        }

        [HttpPut("update-by-id")]
        public void UpdateTeam(Team team)
        {
            TeamRepository.UpdateTeam(team);    
        }

        [HttpPost("insert")]
        public void InsertTeam(Team team)
        {
            TeamRepository.InsertTeam(team);
        }
    }
}




