using ModelStateApp.Models;

namespace AkhshamBazari.Repositories.Base
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task InsertProductAsync(Product product);
    }
}