using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Controllers.V1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    public class AboutController : BaseController
    {
        [HttpGet]
        public string Get() => "Hello world v1";

        [HttpGet]
        [Route("vision")]
        public string Vision() => "Hello world Vision v1";

    }
}
