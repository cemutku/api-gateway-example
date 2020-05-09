using Microsoft.AspNetCore.Mvc;

namespace Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "This is a Basket API";
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"This is a Basket Item with Id : {id}";
        }
    }
}