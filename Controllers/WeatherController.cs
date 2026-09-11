using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [BindProperty(SupportsGet =true)]
        public CountryModel country { get; set; }

        [HttpGet("")]
        public IActionResult AddCountry()
        {
            return Ok(this.country.Area + " " + this.country.Name + " " + this.country.Population);
        }



    }
}
