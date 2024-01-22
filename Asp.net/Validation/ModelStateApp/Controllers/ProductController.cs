namespace ModelStateApp.Controllers;

using ModelStateApp.Models;
using Microsoft.AspNetCore.Mvc;
using AkhshamBazari.Repositories.Base;

public class ProductController : Controller
{
    private readonly IProductRepository productRepository;

    public ProductController(IProductRepository productRepository) {
        this.productRepository = productRepository;
    }

    public async Task<IActionResult> Index()
    {
        var products = await this.productRepository.GetAllAsync();

        return View(model: products);
    }

    [HttpGet]
    public IActionResult Create() {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm]Product newProduct) {
        if(base.ModelState.IsValid == false) {
            return base.BadRequest(base.ModelState);
        }

        await this.productRepository.InsertProductAsync(newProduct);

        return RedirectToAction("Index");

        /*
        System.Console.WriteLine("\n\n\n");
        System.Console.WriteLine(base.ModelState.IsValid);
        foreach (var item in base.ModelState)
        {
            System.Console.WriteLine(item.Key);

            foreach (var error in item.Value.Errors)
            {
                System.Console.WriteLine(error.ErrorMessage);
            } 
            System.Console.WriteLine();
        }
        System.Console.WriteLine("\n\n\n");
        */
    }
}