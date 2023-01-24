using Fifa22.Library.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa22.Library.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public DatabaseHelper DatabaseConnection { get; }

        public PlayerRepository(DatabaseHelper databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<Player> GetPlayers()
        {
            List<Player> player = new List<Player>();
            string query = PlayerQueries.PLAYER_LIST;
            DataTable players = DatabaseConnection.ExecuteQuery(query);
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

        public List<Player> GetPlayersFromTeam(int teamId)
        {
            List<Player> players = new List<Player>();
            string query = string.Format(PlayerQueries.GET_PLAYER_BY_TEAM, teamId);
            DataTable tablePlayers = DatabaseConnection.ExecuteQuery(query);
            foreach (DataRow row in tablePlayers.Rows)
            {
                var p = new Player();
                p.FirstName = row["FirstName"].ToString();
                p.LastName = row["LastName"].ToString();
                players.Add(p);
            }
            return players;
        }

        public List<Player> GetTop5Players()
        {
            List<Player> player = new List<Player>();
            string query = string.Format(PlayerQueries.GET_TOP5_PLAYERS);
            DataTable players = DatabaseConnection.ExecuteQuery(query);
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

        public List<PlayerEx> GetAllPlayersWithGoals()
        {
            var result = new List<PlayerEx>();
            string query = string.Format(PlayerQueries.GET_ALL_PLAYERS_WITH_GOALS);
            DataTable players = DatabaseConnection.ExecuteQuery(query);

            foreach (System.Data.DataRow row in players.Rows)
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

        public void DeletePlayer(int playerId)
        {
            string query = string.Format(PlayerQueries.DeletePlayer, playerId);
            DataTable players = DatabaseConnection.ExecuteQuery(query);
        }

        public void InsertPlayers(Player p)
        {
            string query = string.Format(PlayerQueries.InsertPlayers, p.FirstName, p.LastName, p.GoalCount, p.TeamId);
            DataTable players = DatabaseConnection.ExecuteQuery(query);
        }

        public void UpdatePlayer(Player p)
        {
            string query = string.Format(PlayerQueries.UpdatePlayer, p.FirstName, p.LastName, p.GoalCount, p.PlayerId);
            DataTable players = DatabaseConnection.ExecuteQuery(query);
        }
    }
}
