using Authentication_JWT_DEMO.Models;
using Authentication_JWT_DEMO.Services.Interfaces;
using Authentication_JWT_DEMO.Services.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Authentication_JWT_DEMO.Controllers
{
    [Route("auth/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticateService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticateService = authenticationService;
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                var user = _authenticateService.Authenticate(model.UserName, model.Password);

                if (user == null)
                    return BadRequest(new { message = "User or Password is incorrect" });

                return Ok(user);

            } catch (Exception ex) 
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
