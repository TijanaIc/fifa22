using Fifa22.Data;
using Fifa22.Data.Repositories;

namespace Fifa22.Business.Layer
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository TeamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            TeamRepository = teamRepository;
        }

        public List<Team> GetTeams()
        {
            var teams = TeamRepository.GetTeams();
            return teams;
        }

        public List<Team> GetTeamByName(string groupName)
        {
            var teams = TeamRepository.GetTeamByName(groupName);
            return teams;
        }

        public List<Team> GetTeamById(int teamId)
        {
            var teams = TeamRepository.GetTeamById(teamId);
            return teams;
        }

        public List<TeamEx> GetTeamByGoal(int top)
        {
            var teams = TeamRepository.GetTeamByGoal(top);
            return teams;
        }

        public void InsertTeam(Team team)
        {
            TeamRepository.InsertTeam(team);
        }

        public void UpdateTeam(Team team)
        {
            TeamRepository.UpdateTeam(team);
        }

        public void DeleteTeam(int team_id)
        {
            TeamRepository.DeleteTeam(team_id);
        }
    }
}
