using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        public IDataReader DataReader { get; }

        public GroupController(IDataReader dataReader)
        {
            DataReader = dataReader;
        }

        [HttpGet("list")]    
        public List<Group> Get()
        {
            var groups = DataReader.GetGroups();
            return groups;
        }
    }
}