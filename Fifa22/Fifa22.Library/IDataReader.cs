using System;

namespace Fifa22.Library
{
    public interface IDataReader
    {
        List<Group> GetGroups();
        List<Team> GetTeams();
        List<Team> GetTeamByName(string groupName);
        List<Team> GetTeamById(int teamId);
        List<TeamEx> GetTeamByGoal(int top);
        List<Player> GetPlayers();
        List<Player> GetPlayersFromTeam(int teamId);
    }
}
