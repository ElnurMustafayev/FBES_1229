using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FluentValidationApp.Models;
using FluentValidation;
using FluentValidationApp.Validators;

namespace FluentValidationApp.Controllers;

public class HomeController : Controller
{
    private readonly IValidator<User> userValidator;

    public HomeController(IValidator<User> userValidator)
    {
        this.userValidator = userValidator;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateUser([FromForm] User newUser)
    {
        var result = this.userValidator.Validate(newUser);

        // if(result.IsValid == false) {
        //     base.ModelState.SetFromFluentValidation(result);
        // }

        if(result.IsValid == false) {
            foreach (var error in result.Errors)
            {
                base.ModelState.AddModelError(
                    key: error.PropertyName,
                    errorMessage:error.ErrorMessage
                );
            }

            return base.View("Index");
        }

        return base.RedirectToAction("Index");
    }
}
