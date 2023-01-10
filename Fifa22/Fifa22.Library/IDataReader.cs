using System;

namespace Fifa22.Library
{
    public interface IDataReader
    {
        List<Group> GetGroups();
        List<Team> Get();
        List<Team> GetTeam(string groupName);
        List<Player> GetPlayers();
        List<Player> GetPlayersFromTeam(int teamId);
    }
}
