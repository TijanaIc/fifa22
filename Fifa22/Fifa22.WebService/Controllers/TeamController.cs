﻿using Fifa22.Business.Layer.Teams;
using Fifa22.Data;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        private readonly ITeamService TeamService;
        private readonly ILogger<TeamController> Logger;

        public TeamController(ITeamService teamBusinessLayer, ILogger<TeamController> logger)
        {
            TeamService = teamBusinessLayer;
            Logger = logger;
        }

        [HttpGet("list")]
        public List<Team> Get()
        {
            Logger.LogInformation("Getting list of groups started.");
            var teams = TeamService.GetTeams();
            Logger.LogInformation("Getting list of groups finished.");
            return teams;
        }

        [HttpGet("search-by-group/{groupName}")]
        public List<Team> GetTeams(string groupName)
        {
            var teams = TeamService.GetTeamByName(groupName);
            return teams;
        }

        [HttpGet("search-by-id/{teamId}")]
        public List<Team> GetTeamById(int teamId)
        {
            var teams = TeamService.GetTeamById(teamId);
            return teams;
        }

        [HttpGet("search-by-goals/{top}")]
        public List<TeamEx> GetTeamByGoal(int top)
        {
            var teams = TeamService.GetTeamByGoal(top);
            return teams;
        }

        [HttpDelete("delete-by-id/{team_id}")]
        public void DeleteTeam(int team_id)
        {
            TeamService.DeleteTeam(team_id);
        }

        [HttpPut("update-by-id")]
        public void UpdateTeam(Team team)
        {
            TeamService.UpdateTeam(team);    
        }

        [HttpPost("insert")]
        public void InsertTeam(Team team)
        {
            TeamService.InsertTeam(team);
        }
    }
}




