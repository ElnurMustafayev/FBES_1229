namespace AkhshamBazari.Repositories;

using AkhshamBazari.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using ModelStateApp.Data;
using ModelStateApp.Models;

public class ProductRepository : IProductRepository
{
    private readonly MyDbContext dbContext;

    public ProductRepository(MyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await this.dbContext.Products.ToListAsync();
    }

    public async Task InsertProductAsync(Product product) {
        await this.dbContext.Products.AddAsync(product);
        await this.dbContext.SaveChangesAsync();
    }
}