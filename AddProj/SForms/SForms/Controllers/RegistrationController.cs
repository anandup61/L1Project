using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SForms.Models;
using SForms.Reposetry;

namespace SForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistration registration;
        public RegistrationController(IRegistration registration)
        {
            this.registration = registration;
        }
        [HttpGet("GetRegistered")]
        public IActionResult GetRegistration()
        {
           try
            {
              var reg=  registration.GetRegistered();
                return Ok(reg);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost("AddPerson")]
        [EnableCors("AllowOrigin")]
        public IActionResult AddPerson(Registration Reg)
        {
            try
            {

                registration.Addone(Reg);
                return Ok("user added succesfully");
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        [HttpPut("Update")]
        public IActionResult updade(Registration updd)
        {
            registration.UpdateData(updd);
            return Ok(updd);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            registration.DeletePerson(id);
            return Ok();
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var reg = registration.GetById(id);
            return Ok(reg);
        }
        [HttpGet("GetRegisteredList")]
        public IActionResult GetAllRegisteredList()
        {
            var reg = registration.GetRegisteredList();
            return Ok(reg);

        }
    }
}
