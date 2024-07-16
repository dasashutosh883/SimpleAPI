using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController, Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "hello , G Gobinda Whats up";
        }
        [HttpGet("status")]
        public ActionResult<string> GetStatus(int id)
        {
            return "api is running"+DateTime.Now;
        }
    }
}