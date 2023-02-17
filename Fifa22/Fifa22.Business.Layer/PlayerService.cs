using Fifa22.Data;
using Fifa22.Data.Repositories;

namespace Fifa22.Business.Layer
{
    public class PlayerService : IPlayerService
    {
        public IPlayerRepository PlayerRepository { get; }

        public PlayerService(IPlayerRepository playerRepository)
        {
            PlayerRepository = playerRepository;
        }

        public List<Player> GetPlayers()
        {
            var players = PlayerRepository.GetPlayers();
            return players;
        }

        public List<Player> GetPlayersFromTeam(int teamId)
        {
            var players = PlayerRepository.GetPlayersFromTeam(teamId);
            return players;
        }

        public List<Player> GetTop5Players()
        {
            var players = PlayerRepository.GetTop5Players();
            return players;
        }

        public List<PlayerEx> GetAllPlayersWithGoals()
        {
            var result = new List<PlayerEx>();
            var players = PlayerRepository.GetAllPlayersWithGoals();
            return players;
        }

        public void DeletePlayer(int playerId)
        {
            PlayerRepository.DeletePlayer(playerId);
        }

        public void InsertPlayers(Player p)
        {
            PlayerRepository.InsertPlayers(p);
        }

        public void UpdatePlayer(Player p)
        {
            PlayerRepository.UpdatePlayer(p);
        }
    }
}
