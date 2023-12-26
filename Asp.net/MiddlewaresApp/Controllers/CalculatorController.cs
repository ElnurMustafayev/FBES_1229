using Microsoft.AspNetCore.Mvc;

namespace MiddlewaresApp.Controllers;

[Route("/[controller]/[action]")]
public class CalculatorController : Controller
{
    public IActionResult Sum(int num1, int num2)
    {
        return NotFound(num1 + num2);
    }

    public IActionResult Minus(int num1, int num2)
    {
        return NotFound(num1 - num2);
    }
}