using ProductsWebApi.Repositories;
using ProductsWebApi.Repositories.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepository, ProductPostgreSqlRepository>();
builder.Services.Decorate<IProductRepository, ProductRedisCacheRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();