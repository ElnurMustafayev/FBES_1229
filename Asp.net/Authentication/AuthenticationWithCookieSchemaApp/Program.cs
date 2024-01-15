using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => {
        options.LoginPath = "/Identity/Login";
        options.ReturnUrlParameter = "returnUrl";
    });
builder.Services.AddAuthorization();
    

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

// app.Use(async (HttpContext context, RequestDelegate next) =>
// {
//     if (context.User.Claims.Any())
//         await next.Invoke(context);

//     context.Response.StatusCode = 401;
// });

app.Run();