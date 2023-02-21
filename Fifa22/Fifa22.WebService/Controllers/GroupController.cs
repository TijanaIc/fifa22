using Fifa22.Business.Layer;
using Fifa22.Data;
using Microsoft.AspNetCore.Mvc;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        public IGroupService GroupService { get; }
        public ILogger<GroupController> Logger { get; }

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