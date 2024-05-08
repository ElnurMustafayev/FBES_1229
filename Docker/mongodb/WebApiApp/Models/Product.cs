#pragma warning disable CS8618

namespace WebApiApp.Models;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public IEnumerable<string>? Tags { get; set; }
}