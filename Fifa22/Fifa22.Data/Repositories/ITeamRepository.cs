namespace Fifa22.Data.Repositories
{
    public interface ITeamRepository
    {
        List<Team> GetTeams();
        List<Team> GetTeamByName(string groupName);
        List<Team> GetTeamById(int teamId);
        List<TeamEx> GetTeamByGoal(int top);
        void InsertTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(int team_id);
    }
}
