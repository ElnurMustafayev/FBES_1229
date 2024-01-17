using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Identity/Login";
        options.ReturnUrlParameter = "returnUrl";

        options.AccessDeniedPath = "/Identity/Forbidden";
    });
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Administrators", (policyBuilder) =>
    {
        // policyBuilder.RequireClaim("admin");

        policyBuilder.RequireClaim(ClaimTypes.Role, "admin");
    });
});


var app = builder.Build();

app.UseExceptionHandler("/Home/Error");
app.UseHsts();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();