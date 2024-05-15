namespace ProductsWebApi.Repositories;

using System.Threading.Tasks;
using Dapper;
using Npgsql;
using ProductsWebApi.Models;
using ProductsWebApi.Repositories.Base;

public class ProductPostgreSqlRepository : IProductRepository
{
    private readonly string connectionString;

    public ProductPostgreSqlRepository(IConfiguration configuration)
    {
        this.connectionString = configuration.GetConnectionString("PostgreSql")!;
    }
    public async Task CreateAsync(Product product)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        await connection.ExecuteAsync(
            @"insert into Products (Id, Name, Price)
                values (@Id, @Name, @Price)",
            product
        );
    }

    public async Task<Product?> GetAsync(int id)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        var product = await connection.QueryFirstOrDefaultAsync<Product>(
            "select * from Products where Id = @Id",
            new {
                Id = id
            }
        );

        return product;
    }
}