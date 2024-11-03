using Microsoft.AspNetCore.Mvc;
using WebApplication1.classes;
using WebApplication1.servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        readonly MessageServies m;
        public MessageController()
        {
            m = new MessageServies();
        }
        // GET: api/<MessageController>
        [HttpGet]
        public Message Get(string id)
        {
            Message m1 = m.GetMessageByid(id);
            if (m1 != null)
            {
                return m1;
            }
            return null;
        }

        // GET api/<MessageController>/5
        [HttpGet("{id}")]
        public string Get()
        {
            return "value";
        }

        // POST api/<MessageController>
        [HttpPost]
        public void Post([FromBody] Message m1)
        {
            m.AddMessages(m1);
        }

        // PUT api/<MessageController>/5
        [HttpPut("{id}")]
        public void Put(string target, string title, [FromBody] Message m1)
        {
            m.UpDateMessage(target, title, m1);
        }

        // DELETE api/<MessageController>/5
        [HttpDelete("{id}")]
        public void Delete(string tar, string tit)
        {
            m.DeleteMessages(tar, tit);
        }
    }
}
