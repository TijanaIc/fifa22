using System;

namespace Fifa22.Library
{
    public class ServiceReader : IDataReader
    {
        public List<Group> GetGroups()
        {
            var result = HttpClientHelper.GetRequest<List<Group>>("http://localhost:55667/group/list");
            return result;
        }
        public List<Team> GetTeams()
        {
            var result = HttpClientHelper.GetRequest<List<Team>>("http://localhost:55667/team/list");
            return result;
        }

        public List<Team> GetTeamByName(string groupName)
        {
            var result = HttpClientHelper.GetRequest<List<Team>>($"http://localhost:55667/team/search-by-group/{groupName}");
            return result;
        }

        public List<Team> GetTeamById(int teamId)
        {
            var result = HttpClientHelper.GetRequest<List<Team>>($"http://localhost:55667/team/search-by-id/{teamId}");
            return result;
        }

        public List<TeamEx> GetTeamByGoal(int top)
        {
            var result = HttpClientHelper.GetRequest<List<TeamEx>>($"http://localhost:55667/team/search-by-goals/{top}");
            return result;
        }

        public List<Player> GetPlayers()
        {
            var result = HttpClientHelper.GetRequest<List<Player>>($"http://localhost:55667/player/list");
            return result;
        }

        public List<Player> GetPlayersFromTeam(int teamId)
        {
            var result = HttpClientHelper.GetRequest<List<Player>>($"http://localhost:55667/player/search-by-team/{teamId}");
            return result;
        }
    }
}
