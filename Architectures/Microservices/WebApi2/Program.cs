var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("api/second/{text}", (string text, int number) =>
{
    return $"#{number} Message: {text}";
});

app.Run();