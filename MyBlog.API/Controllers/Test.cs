using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Ok("Test davay");
        }
    }
}
