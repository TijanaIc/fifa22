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

        public List<Team> GetTeam(string groupName)
        {
            var result = HttpClientHelper.GetRequest<List<Team>>($"http://localhost:55667/team/search-by-group/{groupName}");
            return result;
        }

        public List<Player> GetPlayersFromTeam(int teamId)
        {
            var result = HttpClientHelper.GetRequest<List<Player>>($"http://localhost:55667/player/search-by-team/{teamId}");
            return result;
        }
    }
}
