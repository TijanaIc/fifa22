using Fifa22.Library;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace Fifa22.Tests
{
    public class GroupControllerTests
    {
        private readonly WebApplicationFactory<Program> _factory;

        public GroupControllerTests()
        {
            _factory = new WebApplicationFactory<Program>();
        }

        [Fact]
        public async Task GroupNumber_Test()
        {
            var httpClient = _factory.CreateDefaultClient();
            var groups = await httpClient.GetFromJsonAsync<IEnumerable<Group>>("/group/list");
            Assert.NotNull(groups);
            Assert.True(8 == groups.Count());
        }
    }
}
