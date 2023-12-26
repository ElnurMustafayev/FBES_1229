using MiddlewaresApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<LogMiddleware>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();


app.UseMiddleware<LogMiddleware>();
app.UseMiddleware<CheckMiddleware>();
// app.UseHttpsRedirection();

app.Run();