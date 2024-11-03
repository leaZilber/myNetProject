using Microsoft.AspNetCore.Mvc;
using WebApplication1.classes;
using WebApplication1.servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseCommitteeController : ControllerBase
    {
        readonly HouseCommitteeServies h;
        public HouseCommitteeController()
        {
            h = new HouseCommitteeServies();
        }
        // GET: api/<HouseCommitteeController>
        [HttpGet]
        public HouseCommittee Get(string id)
        {
            HouseCommittee h1=h.GetHouseCommByid(id);
            if(h1 != null)
            {
                return h1;
            }
            return null;
        }

        // GET api/<HouseCommitteeController>/5
        [HttpGet("{id}")]
        public string Get()
        {
            return "value";
        }

        // POST api/<HouseCommitteeController>
        [HttpPost]
        public void Post([FromBody] HouseCommittee h2)
        {
            h.AddHouseCommittee(h2);
        }

        // PUT api/<HouseCommitteeController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] string phone, HouseCommittee h1)
        {
            h.UpDateHouse(phone,h1);
        }

        // DELETE api/<HouseCommitteeController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            h.DeleteHouse(id);
        }
    }
}
