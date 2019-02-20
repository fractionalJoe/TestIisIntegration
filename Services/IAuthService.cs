using System.Security.Claims;
using System.Threading.Tasks;

namespace TestIisIntegration
{
    public interface IAuthService
    {
        Task<ClaimsPrincipal> AuthenticateClaims(ClaimsPrincipal principal);
    }
}