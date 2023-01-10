using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        public IDataReader DataReader { get; }
        public DatabaseHelper DatabaseHelper { get; }

        public GroupController(IDataReader dataReader, DatabaseHelper databaseHelper)
        {
            DataReader = dataReader;
            DatabaseHelper = databaseHelper;
        }

        [HttpGet("list")]    
        public List<Group> Get()
        {
            var groups = DataReader.GetGroups();
            return groups;
        }
    }
}