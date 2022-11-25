using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SForms.Models;
using SForms.Reposetry;

namespace SForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IState state;
        public StateController(IState state)
        {
            this.state = state; 
        }
        [HttpGet("GetState")]
        [EnableCors("AllowOrigin")]
        public IActionResult GetState()
        {
          try
            {
                var st = state.GetState();
                return Ok(st);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddState")]
        public IActionResult AddState(States states )
        {
           try
            {
                state.AddState(states);
                return Ok(states);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
