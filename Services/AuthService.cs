using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TestIisIntegration
{
    public class AuthService : IAuthService
    {
        #region fields
        private readonly HttpContext HttpContext;
        #endregion

        #region ctors
        public AuthService(IHttpContextAccessor httpContextAccessor)
        {
            HttpContext = httpContextAccessor.HttpContext;
        }
        #endregion

        #region methods
        public async Task<ClaimsPrincipal> AuthenticateClaims(ClaimsPrincipal principal)
        {
            string testValue = HttpContext.Session.GetString("TestKey");
            if (testValue == null)
            {
                HttpContext.Session.SetString("TestKey", "TestValue");
            }
            return await Task.FromResult(principal);
        }
        #endregion
    }
}