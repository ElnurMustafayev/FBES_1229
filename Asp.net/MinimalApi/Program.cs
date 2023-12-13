using System.Net;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/test", async (context) => {
    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
    context.Response.ContentType = "application/json";
    await context.Response.WriteAsync("GET");
});

app.MapGet("/myfilter", (int? num, string? name) => {
    var result = $"{num} {name}";
    return result;
});

app.MapPost("/test", async (context) => {
    await context.Response.WriteAsync("POST");
});

app.Run();