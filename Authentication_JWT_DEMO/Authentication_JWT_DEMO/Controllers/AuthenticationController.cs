using Authentication_JWT_DEMO.Models;
using Authentication_JWT_DEMO.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_JWT_DEMO.Controllers
{
    [Route("auth/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticateService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticateService = authenticationService;
        }


        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            var user = _authenticateService.Authenticate(model.UserName, model.Password);

            if (user == null)
                return BadRequest(new { message = "User or Password is incorrect" });

            return Ok(user);

        }
    }
}
