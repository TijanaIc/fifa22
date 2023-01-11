using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;


namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        public IDataReader DataReader { get; }
        public DatabaseHelper DatabaseHelper { get; }

        public PlayerController(IDataReader dataReader, DatabaseHelper databaseHelper)
        {
            DataReader = dataReader;
            DatabaseHelper = databaseHelper;
        }

        [HttpGet("list")]
        public List<Player> GetPlayers()
        {
            var players = DataReader.GetPlayers();
            return players;
        }

        [HttpGet("search-by-team/{teamId}")]
        public List<Player> GetPlayersFromTeam(int teamId)
        {
            var players = DataReader.GetPlayersFromTeam(teamId);
            return players;            
        }

        [HttpGet("search-by-GoalCount")]
        public List<Player> GetTop5Players()
        {
            var players = DataReader.GetTop5Players();
            return players;
        }
        
        [HttpGet("search-by-players-with-goals")]
        public List<PlayerEx> GetAllPlayersWithGoals()
        {
            var result = new List<PlayerEx>();
            var table = DataReader.GetTop5Players();
            return result;
        }

        [HttpDelete("delete-by-id/{playerId}")]
        public void DeletePlayer(int playerId)
        {
            DatabaseHelper.ExecuteQuery($"delete from Player where PlayerId = '{playerId}'");
        }

        [HttpPost("insert")]
        public void InsertPlayers(Player p)
        {
            DatabaseHelper.ExecuteQuery($"INSERT INTO Player VALUES ('{p.FirstName}', '{p.LastName}',{p.GoalCount},{p.TeamId})");
        }

        [HttpPut("update-by-id")]
        public void UpdatePlayer(Player p)
        {
            DatabaseHelper.ExecuteQuery($"UPDATE Player SET FirstName = '{p.FirstName}', LastName = '{p.LastName}',GoalCount = {p.GoalCount} where PlayerId = {p.PlayerId}");
        }

    }
}
