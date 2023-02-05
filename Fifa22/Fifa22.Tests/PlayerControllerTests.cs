using Fifa22.Data;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace Fifa22.Tests
{
    public class PlayerControllerTests
    {
        private readonly WebApplicationFactory<Program> _factory;
        public PlayerControllerTests()
        {
            _factory = new WebApplicationFactory<Program>();
        }

        [Fact]
        public async Task GetPlayers_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var players = await httpClient.GetFromJsonAsync<IEnumerable<Player>>("/player/list");
            Assert.NotNull(players);
            Assert.True(24 == players.Count());
        }

        [Fact]
        public async Task GetTop5Players_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var players = await httpClient.GetFromJsonAsync<IEnumerable<Player>>("/player/search-by-GoalCount");
            Assert.NotNull(players);
            Assert.True(5 == players.Count());
        }

        [Fact]
        public async Task GetAllPlayersWithGoals_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var players = await httpClient.GetFromJsonAsync<IEnumerable<PlayerEx>>("/player/search-by-players-with-goals");
            Assert.NotNull(players);
            Assert.True(24 == players.Count());
        }

        [Fact]
        public async Task GetPlayersFromTeam_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var players = await httpClient.GetFromJsonAsync<IEnumerable<PlayerEx>>("/player/search-by-team/1");
            Assert.NotNull(players);
            Assert.True(1 == players.Count());
        }
    }
}
