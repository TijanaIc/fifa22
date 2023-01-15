using Fifa22.Library;
using Fifa22.Library.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        public IGroupRepository GroupRepository { get; }

        public GroupController(IGroupRepository groupRepository)
        {
            GroupRepository = groupRepository;
        }

        [HttpGet("list")]    
        public List<Group> Get()
        {
            var groups = GroupRepository.GetGroups();
            return groups;
        }
    }
}