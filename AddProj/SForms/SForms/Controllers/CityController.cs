using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SForms.Models;
using SForms.Reposetry;

namespace SForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICity cityService;
        public CitiesController(ICity cityService)
        {
            this.cityService = cityService;

        }
        [HttpGet("GetCities")]
        [EnableCors("AllowOrigin")]
        public IActionResult GetCity()
        {
          try
            {
                var res = cityService.GetCities();
                return Ok(res);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost("AddCity")]
        public IActionResult AddCity(City cities)
        {
            try
            {
                cityService.AddCity(cities);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
