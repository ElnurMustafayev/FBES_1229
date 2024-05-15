namespace ProductsWebApi.Repositories;

using System.Text.Json;
using ProductsWebApi.Models;
using ProductsWebApi.Repositories.Base;
using StackExchange.Redis;

public class ProductRedisCacheRepository : IProductRepository
{
    private readonly string redisConnectionString;
    private readonly IProductRepository productRepository;

    public ProductRedisCacheRepository(IConfiguration configuration, IProductRepository productRepository)
    {
        this.redisConnectionString = configuration.GetConnectionString("Redis")!;
        this.productRepository = productRepository;
    }

    public async Task CreateAsync(Product product) {
        await this.productRepository.CreateAsync(product);
    }

    public async Task<Product?> GetAsync(int id)
    {
        var redisConnection = ConnectionMultiplexer.Connect(this.redisConnectionString);
        var redisDb = redisConnection.GetDatabase();

        var productRedisKey = $"product_{id}";
        var productRedisValue = await redisDb.StringGetAsync(productRedisKey);

        if(productRedisValue.HasValue) {
            var productFromCache = JsonSerializer.Deserialize<Product>(productRedisValue);

            return productFromCache;
        }
        var product = await productRepository.GetAsync(id);

        if(product != null) {
            await redisDb.StringSetAsync(productRedisKey, JsonSerializer.Serialize(product));
        }

        return product;
    }
}