using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NotepadOnline.API.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        [HttpGet("get")]
        public IActionResult GetTestData()
        {
            return Ok("hello");
        }
    }
}