using System.Security.Claims;
using System.Threading.Tasks;
using AlgorithmEasy.Shared.Requests;
using AlgorithmEasy.Shared.Responses;
using AlgorithmEasy.Shared.Statuses;
using Microsoft.AspNetCore.Components.Authorization;

namespace AlgorithmEasy.Shared.Services
{
    public abstract class AuthenticationService : AuthenticationStateProvider
    {
        public virtual LoginResponse User { get; protected set; }

        public abstract Task<LoginStatus> Login(LoginRequest request);

        public abstract void Logout();

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = GetClaimsIdentity("Session");
            var claims = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(claims));
        }

        protected virtual ClaimsIdentity GetClaimsIdentity(string authenticationType = null)
        {
            ClaimsIdentity identity;

            if (User == null)
                identity = new ClaimsIdentity();
            else
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, User.UserId),
                    new Claim(ClaimTypes.Role, User.Role),
                    new Claim("Json Web Token", User.Token)
                }, authenticationType);

            return identity;
        }
    }
}