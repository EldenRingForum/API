using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumAPI.Areas.WebForum.Controllers.EntryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Google : ControllerBase
    {
        // GET: api/<Google>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Google>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Google>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Google>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Google>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
