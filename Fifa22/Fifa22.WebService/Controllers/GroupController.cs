using Fifa22.Business.Layer;
using Fifa22.Data;
using Microsoft.AspNetCore.Mvc;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        public IBusinessLayer BusinessLayer { get; }

        public GroupController(IBusinessLayer groupBusinessLayer)
        {
            BusinessLayer = groupBusinessLayer;
        }

        [HttpGet("list")]    
        public List<Group> Get()
        {
            var groups = BusinessLayer.GetGroups();
            return groups;
        }
    }
}