using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SForms.Models;
using SForms.Reposetry;

namespace SForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandardController : ControllerBase
    {
        private readonly IStandard standard;
        public StandardController(IStandard standard)
        {
            this.standard = standard;   
        }
        [HttpGet("AddStd")]
        public IActionResult GetStd()
        {

            try
            {
                var std = standard.GetStandard();
                return Ok(std);
            }
            catch(Exception exp)
            {
                throw exp;
            }
        }
        [HttpPost("AddStd")]
        public IActionResult AddStd(Standard std)
        {
          try
            {
                standard.AddStandard(std);
                return Ok(std);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("UpdateStd")]
        public IActionResult Update(Standard sttd)
        {
            standard.Update(sttd);
            return Ok(sttd);
        }
    }
}
