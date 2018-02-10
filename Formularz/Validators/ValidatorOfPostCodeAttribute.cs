using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Formularz.Validators
{
    public class ValidatorOfPostCodeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            Regex a = new Regex("^[0-9]{2}-[0-9]{3}");
            if (a.IsMatch(value.ToString()))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Wprowadź poprawny kod");
            }
        }
    }
}