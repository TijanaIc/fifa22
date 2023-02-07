using Fifa22.Business.Layer;
using Fifa22.Data;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        public IBusinessLayer BusinessLayer { get; }

        public PlayerController(IBusinessLayer playerBusinessLayer)
        {
            BusinessLayer = playerBusinessLayer;
        }

        [HttpGet("list")]
        public List<Player> GetPlayers()
        {
            var players = BusinessLayer.GetPlayers();
            return players;
        }

        [HttpGet("search-by-team/{teamId}")]
        public List<Player> GetPlayersFromTeam(int teamId)
        {
            var players = BusinessLayer.GetPlayersFromTeam(teamId);
            return players;            
        }

        [HttpGet("search-by-GoalCount")]
        public List<Player> GetTop5Players()
        {
            var players = BusinessLayer.GetTop5Players();
            return players;
        }
        
        [HttpGet("search-by-players-with-goals")]
        public List<PlayerEx> GetAllPlayersWithGoals()
        {
            var result = new List<PlayerEx>();
            var players = BusinessLayer.GetAllPlayersWithGoals();
            return players;
        }

        [HttpDelete("delete-by-id/{playerId}")]
        public void DeletePlayer(int playerId)
        {
            BusinessLayer.DeletePlayer(playerId);
        }

        [HttpPost("insert")]
        public void InsertPlayers(Player p)
        {
            BusinessLayer.InsertPlayers(p);  
        }

        [HttpPut("update-by-id")]
        public void UpdatePlayer(Player p)
        {
            BusinessLayer.UpdatePlayer(p);
        }
    }
}
