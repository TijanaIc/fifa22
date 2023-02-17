using Fifa22.Data;

namespace Fifa22.Business.Layer
{
    public interface IPlayerService
    {
        List<Player> GetPlayers();
        List<Player> GetPlayersFromTeam(int teamId);
        List<Player> GetTop5Players();
        List<PlayerEx> GetAllPlayersWithGoals();
        void DeletePlayer(int playerId);
        void InsertPlayers(Player p);
        void UpdatePlayer(Player p);
    }
}
