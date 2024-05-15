var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("api/first", () =>
{
    return new {
        Name = "Elnur",
        Surname = "Mustafayev"
    };
});

app.Run();