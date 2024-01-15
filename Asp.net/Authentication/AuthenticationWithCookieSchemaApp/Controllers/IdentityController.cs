using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AuthenticationWithCookieSchemaApp.Dtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationWithCookieSchemaApp.Controllers
{
    [Route("[controller]/[action]")]
    public class IdentityController : Controller
    {
        [HttpGet("/api/[controller]/Claims")]
        [Authorize]
        public string GetClaims() {
            var sb = new StringBuilder(100);

            foreach (var claim in base.User.Claims)
            {
                sb.Append($"{claim.Type}: {claim.Value}\n");
            }

            return sb.ToString();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string? returnUrl) {
            base.ViewData["returnUrl"] = returnUrl;

            return base.View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromForm] LoginDto loginDto) {
            var claims = new Claim[] {
                new Claim(ClaimTypes.Name, loginDto.Login),
                new Claim("creation_date_utc", DateTime.UtcNow.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            base.HttpContext.SignInAsync(
                scheme: CookieAuthenticationDefaults.AuthenticationScheme,
                principal: new ClaimsPrincipal(claimsIdentity)
            );

            if(string.IsNullOrWhiteSpace(loginDto.ReturnUrl)) 
                return base.RedirectToAction(controllerName: "Home", actionName: "Index");
                
            return base.RedirectPermanent(loginDto.ReturnUrl);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> LogOut() {
            await base.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return base.RedirectToAction(actionName: "Login");
        }
    }
}