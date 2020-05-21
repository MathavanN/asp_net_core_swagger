using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Test.Controllers.V1
{
    [ApiVersion("1.0")]
    public class CountryController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllAsync()
        {
            var countries = await Context.Countries.ToListAsync();
            return Ok(countries);
        }
    }
}