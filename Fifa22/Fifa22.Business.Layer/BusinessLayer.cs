using Fifa22.Data;
using Fifa22.Data.Repositories;

namespace Fifa22.Business.Layer
{
    public class BusinessLayer : IBusinessLayer
    {
        public IGroupRepository GroupRepository { get; }
        public ITeamRepository TeamRepository { get; }
        public IPlayerRepository PlayerRepository { get; }

        public BusinessLayer(IGroupRepository groupRepository, ITeamRepository teamRepository, IPlayerRepository playerRepository)
        {
            GroupRepository = groupRepository;
            TeamRepository = teamRepository;
            PlayerRepository = playerRepository;
        }
        public List<Group> GetGroups()
        {
                var groups = GroupRepository.GetGroups();
                return groups;
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


