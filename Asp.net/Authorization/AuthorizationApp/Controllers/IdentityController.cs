using System.Security.Claims;
using System.Text;
using AuthorizationApp.Dtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationApp.Controllers
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
        [Authorize]
        public IActionResult Forbidden(string? returnUrl) {
            ViewData["returnUrl"] = returnUrl;

            return View();
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
            //new Claim("role", "user");
            //new Claim("role", "admin");

            var roleName = loginDto.Login.Contains("admin")
                ? "admin"
                : "user";

            var claims = new List<Claim> {
                new(ClaimTypes.Name, loginDto.Login),
                new(ClaimTypes.Role, roleName),
                new("creation_date_utc", DateTime.UtcNow.ToString()),
            };

            // if(loginDto.Login == "admin") {
            //     claims.Add(new("admin", true.ToString()));
            // }

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