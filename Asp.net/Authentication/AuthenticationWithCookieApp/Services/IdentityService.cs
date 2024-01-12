using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationWithCookieApp.Services
{
    public class IdentityService
    {
        private readonly IDataProtector dataProtector;

        public IdentityService(IDataProtectionProvider dataProtectionProvider)
        {
            this.dataProtector = dataProtectionProvider.CreateProtector("TEST");
        }

        public IActionResult GetUserId(ref long userId, HttpContext httpContext) {
            // 1. Check cookie exist
            var authorizeCookie = httpContext.Request.Cookies["Authorize"];

            if(string.IsNullOrWhiteSpace(authorizeCookie)) {
                return new UnauthorizedResult();
                //return base.Unauthorized();
            }

            string? userHashValue = null;

            // 2. Unprotect cookie exist
            try {
                userHashValue = this.dataProtector.Unprotect(authorizeCookie);
            }
            catch(Exception ex) {
                return new BadRequestResult();
            }

            return new OkResult();
        }
    }
}