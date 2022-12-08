using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        [HttpGet("list")]
        public List<Player> Get()
        {
            List<Player> player = new List<Player>();
            DataTable players = DatabaseHelper.ExecuteQuery($"select * from Player");
            foreach (DataRow playerRow in players.Rows)
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
        [HttpGet("search-by-GoalCount")]
        public List<Player> GetTop5Players()
        {
            List<Player> player = new List<Player>();
            DataTable players = DatabaseHelper.ExecuteQuery($"SELECT  TOP 5 * FROM Player ORDER BY GoalCount desc");
            foreach (DataRow playerRow in players.Rows)
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
        [HttpGet("search-by-team/{teamId}")]
        public List<Player> GetPlayersFromTeam(int teamId)
        {
            List<Player> player = new List<Player>();
            DataTable players = DatabaseHelper.ExecuteQuery($"select PlayerId, FirstName, LastName, GoalCount, TeamId from Player where Teamid = '{teamId}'");
            foreach (DataRow playerRow in players.Rows)
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
    }
}
