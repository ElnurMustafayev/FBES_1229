using HeadersApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<HeadersCheckMiddleware>();

var app = builder.Build();

app.MapControllers();
app.UseMiddleware<HeadersCheckMiddleware>();

app.Run();