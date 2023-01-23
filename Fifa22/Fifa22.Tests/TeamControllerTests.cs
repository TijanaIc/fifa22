using Fifa22.Library;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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
    }
}
