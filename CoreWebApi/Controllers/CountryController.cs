using CoreWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreApiAdoDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/Country")]
	[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class CountryController : ControllerBase
    {
        private readonly CountriesDbContext _context;
        public CountryController(CountriesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetCountriesList")]
        public async Task<ActionResult<IEnumerable<CountryModel>>> GetCountriesList()
        {
            return await _context.Countries.ToListAsync();            
        }
    }
}
