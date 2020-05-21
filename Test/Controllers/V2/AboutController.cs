using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers.V2
{
    [ApiVersion("2.0")]
    public class AboutController : BaseController
    {
        [HttpGet]
        [Route("vision")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Vision() => Ok(new { data = "This is Vision Details v2" });
    }
}
