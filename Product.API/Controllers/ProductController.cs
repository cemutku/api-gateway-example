using Microsoft.AspNetCore.Mvc;

namespace Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "This is a Product API";
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"This is a Product Item with Id : {id}";
        }
    }
}