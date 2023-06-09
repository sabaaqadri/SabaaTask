using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SabaaTask.CORE.Data;
using SabaaTask.CORE.Service;
using SabaaTask.INFRA.Service;

namespace SabaaTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        private readonly IJWTService _jWTService;
        public JWTController(IJWTService jWTService)
        {
            _jWTService = jWTService;
        }



        [HttpPost]
        public IActionResult Auth(Userlogin userlogin )
        {
            var token = _jWTService.Auth(userlogin);

            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }






    }
}
