using Fifa22.Data;

namespace Fifa22.Business.Layer
{
    public interface IBusinessLayer
    {
        List<Group> GetGroups();

        List<Team> GetTeams();
        List<Team> GetTeamByName(string groupName);
        List<Team> GetTeamById(int teamId);
        List<TeamEx> GetTeamByGoal(int top);
        void InsertTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(int team_id);

        List<Player> GetPlayers();
        List<Player> GetPlayersFromTeam(int teamId);
        List<Player> GetTop5Players();
        List<PlayerEx> GetAllPlayersWithGoals();
        void DeletePlayer(int playerId);
        void InsertPlayers(Player p);
        void UpdatePlayer(Player p);
    }
}
