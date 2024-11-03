using Microsoft.AspNetCore.Mvc;
using WebApplication1.classes;
using WebApplication1.servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        readonly TenantServies ten;
        public TenantController()
        {
            ten = new TenantServies();
        }

        // GET: api/<TenantController>
        [HttpGet]
        public Tenant Get(string id)
        {
            Tenant t = ten.GetTenantByid(id);
            if (t != null)
            {
                return t;
            }
            return null;
        }

        // GET api/<TenantController>/5
        [HttpGet("{id}")]
        public string Get()
        {
            return "value";
        }

        // POST api/<TenantController>
        [HttpPost]
        public void Post([FromBody] Tenant t)
        {
            ten.AddTenant(t);
        }

        // PUT api/<TenantController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Tenant t,string id)
        {
            ten.UpDateTenant(t,id);
        }

        // DELETE api/<TenantController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            ten.DeleteTenant(id);
        }
    }
}
