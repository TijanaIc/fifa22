namespace Fifa22.Data.Repositories
{
    public interface IPlayerRepository
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
