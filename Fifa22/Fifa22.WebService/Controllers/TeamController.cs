using Fifa22.Business.Layer;
using Fifa22.Data;
using Fifa22.Data.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        public IBusinessLayer BusinessLayer { get; }

        public TeamController(IBusinessLayer teamBusinessLayer)
        {
            BusinessLayer = teamBusinessLayer;
        }

        [HttpGet("list")]
        public List<Team> Get()
        {
            var teams = BusinessLayer.GetTeams();
            return teams;
        }

        [HttpGet("search-by-group/{groupName}")]
        public List<Team> GetTeams(string groupName)
        {
            var teams = BusinessLayer.GetTeamByName(groupName);
            return teams;
        }

        [HttpGet("search-by-id/{teamId}")]
        public List<Team> GetTeamById(int teamId)
        {
            var teams = BusinessLayer.GetTeamById(teamId);
            return teams;
        }

        [HttpGet("search-by-goals/{top}")]
        public List<TeamEx> GetTeamByGoal(int top)
        {
            var teams = BusinessLayer.GetTeamByGoal(top);
            return teams;
        }

        [HttpDelete("delete-by-id/{team_id}")]
        public void DeleteTeam(int team_id)
        {
            BusinessLayer.DeleteTeam(team_id);
        }

        [HttpPut("update-by-id")]
        public void UpdateTeam(Team team)
        {
            BusinessLayer.UpdateTeam(team);    
        }

        [HttpPost("insert")]
        public void InsertTeam(Team team)
        {
            BusinessLayer.InsertTeam(team);
        }
    }
}




