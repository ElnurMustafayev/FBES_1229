namespace ProductsWebApi.Controllers;

using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using ProductsWebApi.Models;
using ProductsWebApi.Repositories.Base;

[Route("/api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository productRepository;

    public ProductController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Product>> GetProductAsync(int id) {
        var product = await productRepository.GetAsync(id);

        if(product == null) {
            return base.NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product) {
        await productRepository.CreateAsync(product);

        return Ok(product);
    }
}