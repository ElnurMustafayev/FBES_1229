using WithParametersApp.Models;
using WithParametersApp.Repositories;

var productsRepository = new ProductsRepository();

productsRepository.Add(new Product("PC", 4400));

var products = productsRepository.GetAll();
foreach (var product in products) {
    Console.WriteLine(product);
}