using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/<HomeController>
        [HttpGet]
        //[Route("getAll")]
        public ActionResult<string> Get()
        {
            return Ok("hello world");
        }

        // GET api/<HomeController>/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return $"hell world from {name}";
        }

        // POST api/<HomeController>
        //[HttpPost("[action]/{id:int}/{name}")]
        //public IActionResult Add([FromRoute] Items item , [FromRoute] Items item1)
        //{
        //    LinkedList<string> list = new LinkedList<string>();
        //    return Ok(); 
        //}

        //// DELETE api/<HomeController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
