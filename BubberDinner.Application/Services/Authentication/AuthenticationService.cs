using BubberDinner.Application.Common.Interfaces.Authentication;

namespace BubberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ITokenService _tokenService;
        public AuthenticationService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        public AuthenticationResult Login(string Email, string Password)
        {

            return new AuthenticationResult(
                Guid.NewGuid(),
                "FirstName",
                "LastName",
                Email,
                "Token"
            );
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {
            var token = _tokenService.GenerateToken(Guid.NewGuid(), FirstName, LastName);

            return new AuthenticationResult(
                Guid.NewGuid(),
                FirstName,
                LastName,
                Email,
                token
            );
        }
    }
}
