using Microsoft.AspNetCore.Mvc;
using ConfigurationApp.Models;
using ConfigurationApp.Repositories.Base;
using Microsoft.Extensions.Options;
using ConfigurationApp.ViewModels;

namespace ConfigurationApp.Controllers;

public class HomeController : Controller
{
    private readonly IUserRepository userRepository;
    private readonly IOptions<Palette> paletteOptions;
    private readonly IOptionsSnapshot<Palette> paletteOptionsSnapshot;
    private readonly IOptionsMonitor<Palette> paletteOptionsMonitor;
    private readonly IConfiguration configuration;

    public HomeController(IUserRepository userRepository, 
        IOptions<Palette> paletteOptions,
        IOptionsSnapshot<Palette> paletteOptionsSnapshot,
        IOptionsMonitor<Palette> paletteOptionsMonitor,
        IConfiguration configuration)
    {
        this.userRepository = userRepository;

        this.paletteOptions = paletteOptions;
        this.paletteOptionsSnapshot = paletteOptionsSnapshot;
        this.paletteOptionsMonitor = paletteOptionsMonitor;
        this.configuration = configuration;

        // this.paletteOptionsMonitor.OnChange((option) => {
        //     System.Console.WriteLine("UPDATED!");
        // });
    }

    public IActionResult Index()
    {
        var connectionString = configuration.GetConnectionString("UsersDb");
        //System.Console.WriteLine(connectionString);
        //var vm = new PaletteViewModel(palette: this.paletteOptions.Value);
        //var vm = new PaletteViewModel(palette: this.paletteOptionsSnapshot.Value);
        var vm = new PaletteViewModel(palette: this.paletteOptionsMonitor.CurrentValue);
        return View(model: vm);
    }
}
