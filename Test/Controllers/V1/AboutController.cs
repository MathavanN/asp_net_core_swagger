using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers.V1
{
    [ApiVersion("1.0")]
    public class AboutController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get() => Ok(new { data = "This is About Details v1" });

        [HttpGet]
        [Route("vision")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Vision() => Ok(new { data = "This is Vision Details v1" });
    }
}
