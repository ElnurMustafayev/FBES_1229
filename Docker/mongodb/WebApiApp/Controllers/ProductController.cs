using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public ProductController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [HttpPost]
        [Route("/api/[controller]")]
        public async Task<IActionResult> CreateProduct(Product newProduct)
        {
            var mongoDbConnectionoString = this.configuration.GetConnectionString("MongoDb");
            var client = new MongoClient(mongoDbConnectionoString);

            var productsDb = client.GetDatabase("ProductsDb");
            await productsDb.CreateCollectionAsync("Products");

            var collection = productsDb.GetCollection<Product>("Products");

            await collection.InsertOneAsync(newProduct);
            return base.Ok();
        }
    }
}
