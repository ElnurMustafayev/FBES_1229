using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelStateApp.Validators
{
    public class MyValidator : ValidationAttribute {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //validationContext.ObjectInstance
            
            if(validationContext.ObjectType == typeof(string))
                return new ValidationResult(null);

            return new ValidationResult($"{value} must be string");
        }
    }
}