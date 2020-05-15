using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Controllers.V2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiVersion("2.0")]
    public class AboutController : BaseController
    {
        [HttpGet]
        [Route("vision")]
        public string Vision() => "Hello world Vision v2!";
    }
}
