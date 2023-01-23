using Fifa22.Library;
using Fifa22.Library.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        public IPlayerRepository PlayerRepository { get; }

        public PlayerController(IPlayerRepository playerRepository)
        {
            PlayerRepository = playerRepository;
        }

        [HttpGet("list")]
        public List<Player> GetPlayers()
        {
            var players = PlayerRepository.GetPlayers();
            return players;
        }

        [HttpGet("search-by-team/{teamId}")]
        public List<Player> GetPlayersFromTeam(int teamId)
        {
            var players = PlayerRepository.GetPlayersFromTeam(teamId);
            return players;            
        }

        [HttpGet("search-by-GoalCount")]
        public List<Player> GetTop5Players()
        {
            var players = PlayerRepository.GetTop5Players();
            return players;
        }
        
        [HttpGet("search-by-players-with-goals")]
        public List<PlayerEx> GetAllPlayersWithGoals()
        {
            var result = new List<PlayerEx>();
            var table = PlayerRepository.GetAllPlayersWithGoals();
            return result;
        }

        //[HttpDelete("delete-by-id/{playerId}")]
        //public void DeletePlayer(int playerId)
        //{
        //    DatabaseHelper.ExecuteQuery($"delete from Player where PlayerId = '{playerId}'");
        //}

        //[HttpPost("insert")]
        //public void InsertPlayers(Player p)
        //{
        //    DatabaseHelper.ExecuteQuery($"INSERT INTO Player VALUES ('{p.FirstName}', '{p.LastName}',{p.GoalCount},{p.TeamId})");
        //}

        //[HttpPut("update-by-id")]
        //public void UpdatePlayer(Player p)
        //{
        //    DatabaseHelper.ExecuteQuery($"UPDATE Player SET FirstName = '{p.FirstName}', LastName = '{p.LastName}',GoalCount = {p.GoalCount} where PlayerId = {p.PlayerId}");
        //}

    }
}
