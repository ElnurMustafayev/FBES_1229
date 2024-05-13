namespace ProductsWebApi.Controllers;

using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using ProductsWebApi.Models;

[Route("/api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IConfiguration configuration;

    public ProductController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Product>> GetProductAsync(int id) {
        var connectionString = configuration.GetConnectionString("PostgreSql");
        using var connection = new NpgsqlConnection(connectionString);

        var product = await connection.QueryFirstOrDefaultAsync<Product>(
            "select * from Products where Id = @Id",
            new {
                Id = id
            }
        );

        if(product == null) {
            return base.NotFound();
        }

        return Ok(product);
    }
}