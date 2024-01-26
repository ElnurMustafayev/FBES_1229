namespace FluentValidationApp.Validators;

using FluentValidation;
using FluentValidation.Results;
using FluentValidationApp.Models;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        base.RuleFor(user => user.Name)
            .NotEmpty()
            .Length(3, 30)
            .NotEqual("badword");

        base.RuleFor(u => u.Age)
            .GreaterThan(18);
    }
}