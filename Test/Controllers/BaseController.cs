using Microsoft.AspNetCore.Mvc;
using Test.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Test.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private TestDataContext _context;
        public TestDataContext Context => _context ?? (_context = HttpContext.RequestServices.GetService<TestDataContext>());
    }
}