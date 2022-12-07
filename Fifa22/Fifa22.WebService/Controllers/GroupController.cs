using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        [HttpGet("list")]    
        public List<Group> Get()
        {
            List<Group> groups = new List<Group>();
            DataTable tableGroups = DatabaseHelper.ExecuteQuery("select distinct Team_group from Team");
            foreach (DataRow row in tableGroups.Rows)
            {
                var g = new Group();
                g.Name = row["Team_group"].ToString();
                groups.Add(g);
            }

            return groups;
        }
    }
}