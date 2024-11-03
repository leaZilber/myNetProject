using Microsoft.AspNetCore.Mvc;
using WebApplication1.servies;
using WebApplication1.classes;
using ServiceProvider = WebApplication1.servies.ServiceProvider;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceProviderController : ControllerBase
    {
        readonly ServiceProviderServies s;
        public ServiceProviderController()
        {
            s = new ServiceProviderServies();
        }
        // GET: api/<ServiceProviderController>
        [HttpGet]
        public ServiceProvider Get(string id)
        {
            ServiceProvider s1 = s.GetProviderServiesByid(id);
            if (s1 != null)
            {
                return s1;
            }
            return null;
        }

        // GET api/<ServiceProviderController>/5
        [HttpGet("{id}")]
        public string Get()
        {
            return "value";
        }

        // POST api/<ServiceProviderController>
        [HttpPost]
        public void Post([FromBody] ServiceProvider ser)
        {
            s.AddService(ser);   
        }

        // PUT api/<ServiceProviderController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] ServiceProvider ser )
        {
            s.UpDateServiceProvider(ser, id);
        }

        // DELETE api/<ServiceProviderController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            s.DeleteService(id);
        }
    }
}
