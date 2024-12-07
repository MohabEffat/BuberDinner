using BubberDinner.Application.Services.Authentication;
using BubberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request)
        { 
            return Ok(_authenticationService.Login(request.Email, request.Password));
        }

        [HttpPost]
        public IActionResult Register(RegisterRequest request)
        {
            return Ok(_authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password));
        }
    }
}
