using Fifa22.Data;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace Fifa22.Tests
{
    public class TeamControllerTests
    {
        private readonly WebApplicationFactory<Program> _factory;
        public TeamControllerTests()
        {
            _factory = new WebApplicationFactory<Program>();
        }

        [Fact]
        public async Task GetTeams_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var teams = await httpClient.GetFromJsonAsync<IEnumerable<Team>>("/team/list");
            Assert.NotNull(teams);
            Assert.True(32 == teams.Count());
        }

        [Fact]
        public async Task GetTeamsByGroupName_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var teams = await httpClient.GetFromJsonAsync<IEnumerable<Team>>("/team/search-by-group/A");
            Assert.NotNull(teams);
            Assert.True(4 == teams.Count());
        }

        [Fact]
        public async Task GetTeamById_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var teams = await httpClient.GetFromJsonAsync<IEnumerable<Team>>("/team/search-by-id/1");
            Assert.NotNull(teams);
            Assert.True(1 == teams.Count());
        }

        [Fact]
        public async Task GetTeamByGoal_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var teams = await httpClient.GetFromJsonAsync<IEnumerable<Team>>("/team/search-by-goals/3");
            Assert.NotNull(teams);
            Assert.True(3 == teams.Count());
        }
    }
}
