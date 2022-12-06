using Fifa22.Library;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Fifa22.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        [HttpGet]
        [Route("list")]
        public List<Team> Get()
        {
            List<Team> team = new List<Team>();
            DataTable teams = DatabaseHelper.ExecuteQuery("select Team_name from Team");
            foreach (DataRow teamRow in teams.Rows)
            {
                var t = new Team();
                t.Team_name = teamRow["Team_name"].ToString();
                team.Add(t);
            }
            return team;
        }
    }
}

