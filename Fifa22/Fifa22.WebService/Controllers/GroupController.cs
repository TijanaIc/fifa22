using Fifa22.Business.Layer;
using Fifa22.Data;
using Microsoft.AspNetCore.Mvc;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService GroupService;
        private readonly ILogger<GroupController> Logger;

        public GroupController(IGroupService groupBusinessLayer, ILogger<GroupController> logger)
        {
            GroupService = groupBusinessLayer;
            Logger = logger;
        }

        [HttpGet("list")]    
        public List<Group> Get()
        {
            Logger.LogInformation("Getting list of groups started.");
            var groups = GroupService.GetGroups();
            Logger.LogInformation("Getting list of groups finished.");
            Logger.LogDebug("debug message.");
            Logger.LogTrace($"trace message.");
            return groups;
        }
    }
}