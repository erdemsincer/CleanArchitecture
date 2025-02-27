using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controller
{
    [ApiController]
    [Route("api[controller]")]
    public sealed class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Deneme Api");
        }
    }
}
