using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Shared.Extensions
{
    public static class ClaimPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal principal)
        {
            var claims = ((ClaimsIdentity)principal.Identity).Claims;
            if (claims.Any())
            {
                return claims.Skip(1).First().Value;
            }
            return null;
        }
    }
}
