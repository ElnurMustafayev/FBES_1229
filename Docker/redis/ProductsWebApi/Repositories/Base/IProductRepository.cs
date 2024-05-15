namespace ProductsWebApi.Repositories.Base;

using ProductsWebApi.Models;

public interface IProductRepository
{
    Task<Product?> GetAsync(int id);
    Task CreateAsync(Product product);
}