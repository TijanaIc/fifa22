using Fifa22.Business.Layer;
using Fifa22.Data;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        private readonly IPlayerService PlayerService;

        public PlayerController(IPlayerService playerBusinessLayer)
        {
            PlayerService = playerBusinessLayer;
        }

        [HttpGet("list")]
        public List<Player> GetPlayers()
        {
            var players = PlayerService.GetPlayers();
            return players;
        }

        [HttpGet("search-by-team/{teamId}")]
        public List<Player> GetPlayersFromTeam(int teamId)
        {
            var players = PlayerService.GetPlayersFromTeam(teamId);
            return players;            
        }

        [HttpGet("search-by-GoalCount")]
        public List<Player> GetTop5Players()
        {
            var players = PlayerService.GetTop5Players();
            return players;
        }
        
        [HttpGet("search-by-players-with-goals")]
        public List<PlayerEx> GetAllPlayersWithGoals()
        {
            var result = new List<PlayerEx>();
            var players = PlayerService.GetAllPlayersWithGoals();
            return players;
        }

        [HttpDelete("delete-by-id/{playerId}")]
        public void DeletePlayer(int playerId)
        {
            PlayerService.DeletePlayer(playerId);
        }

        [HttpPost("insert")]
        public void InsertPlayers(Player p)
        {
            PlayerService.InsertPlayers(p);  
        }

        [HttpPut("update-by-id")]
        public void UpdatePlayer(Player p)
        {
            PlayerService.UpdatePlayer(p);
        }
    }
}
