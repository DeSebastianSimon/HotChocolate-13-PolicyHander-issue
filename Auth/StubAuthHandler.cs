using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace HotChocolate_13_1_Authhandler.Auth
{
    public class StubAuthHandler : AuthenticationHandler<StubAuthHandlerOptions>
    {
        public const string AuthenticationScheme = "StubAuthentication";

        public StubAuthHandler(IOptionsMonitor<StubAuthHandlerOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }
         
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, "Test user") };

            var identity = new ClaimsIdentity(claims, AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, AuthenticationScheme);

            var result = AuthenticateResult.Success(ticket);

            return Task.FromResult(result);
        }
    }

    public class StubAuthHandlerOptions : AuthenticationSchemeOptions
    {
    }
}