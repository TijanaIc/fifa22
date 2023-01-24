using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa22.Library.Repositories
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
