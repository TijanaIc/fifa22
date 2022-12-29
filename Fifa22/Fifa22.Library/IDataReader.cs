using System;

namespace Fifa22.Library
{
    public interface IDataReader
    {
        List<Group> GetGroups();
        List<Team> GetTeam(string groupName);
        List<Player> GetPlayersFromTeam(int teamId);
    }
}
