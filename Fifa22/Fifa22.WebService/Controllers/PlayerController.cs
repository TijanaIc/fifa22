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
            List<Player> player = new List<Player>();
            System.Data.DataTable players = DatabaseHelper.ExecuteQuery($"SELECT  TOP 5 * FROM Player ORDER BY GoalCount desc");
            foreach (System.Data.DataRow playerRow in players.Rows)
            {
                var p = new Player();
                p.PlayerId = Convert.ToInt32(playerRow["PlayerId"]);
                p.FirstName = playerRow["FirstName"].ToString();
                p.LastName = playerRow["LastName"].ToString();
                p.GoalCount = Convert.ToInt32(playerRow["GoalCount"]);
                p.TeamId = Convert.ToInt32(playerRow["TeamId"]);

                player.Add(p);
            }
            return player;
        }
        
        [HttpGet("search-by-players-with-goals")]
        public List<PlayerEx> GetAllPlayersWithGoals()
        {
            var result = new List<PlayerEx>();
            var table = DatabaseHelper.ExecuteQuery($"SELECT Player.FirstName, Player.LastName, Team.Team_name, Team.Team_group, Player.PlayerId, Player.GoalCount, Player.TeamId FROM Player INNER JOIN Team ON Player.Teamid=Team.Team_id;");

            foreach (System.Data.DataRow row in table.Rows)
            {
                var t = new PlayerEx();
                t.PlayerId = Convert.ToInt32(row["PlayerId"]);
                t.FirstName = row["FirstName"].ToString();
                t.LastName = row["LastName"].ToString();
                t.Team_name = row["Team_name"].ToString();
                t.Team_group = row["Team_group"].ToString();
                t.GoalCount = Convert.ToInt32(row["GoalCount"]);
                t.TeamId = Convert.ToInt32(row["TeamId"]);
                result.Add(t);               
            }

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
