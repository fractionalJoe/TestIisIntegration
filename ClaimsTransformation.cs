using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace TestIisIntegration
{
    internal class ClaimsTransformation : IClaimsTransformation
    {
        #region fields
        private readonly HttpContext HttpContext;
        #endregion

        #region ctors
        public ClaimsTransformation(IHttpContextAccessor httpContextAccessor, ILogger<ClaimsTransformation> logger)
        {
            HttpContext = httpContextAccessor.HttpContext;
        }
        #endregion

        #region methods
        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            HttpContext.Session.SetString("TestKey", "TestValue");
            return await Task.FromResult(principal);
        }
        #endregion
    }
}