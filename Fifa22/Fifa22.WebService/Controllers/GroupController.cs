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

        public GroupController(IGroupService groupBusinessLayer)
        {
            GroupService = groupBusinessLayer;
        }

        [HttpGet("list")]    
        public List<Group> Get()
        {
            var groups = GroupService.GetGroups();
            return groups;
        }
    }
}