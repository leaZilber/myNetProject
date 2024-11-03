using Microsoft.AspNetCore.Mvc;
using WebApplication1.classes;
using WebApplication1.servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        readonly BuildingServies build;
        public BuildingController()
        {
            build = new BuildingServies();
        }
        // GET: api/<BuildingController>
        [HttpGet]
        public Building Get(string id)
        {
            Building temp = build.GetBuildingByid(id);
            if (temp != null)
            {
                return temp;
            }
            return null;
        }

        // GET api/<BuildingController>/5
        [HttpGet("{id}")]
        public string Get()
        {
            return "value";
        }

        // POST api/<BuildingController>
        [HttpPost]
        public void Post([FromBody] Building newBuild)
        {
            build.AddBuilding(newBuild);
        }

        // PUT api/<BuildingController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Building b,string id)
        {
            build.UpDateBuild(b,id);
        }

        // DELETE api/<BuildingController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            build.DeleteBuilding(id);
        }
    }
}
