using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Formularz.Validators
{
    public class IsFirstLetterUpperCaseattribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                if (value == null)
                {
                   return new ValidationResult("Wprowadź imię i nazwisko");
                }

                var a = new Regex("^[A-Ż]}");
                var words = value.ToString().Split();
                foreach (var wo in words)
                {
                    return a.IsMatch(wo) ? ValidationResult.Success : new ValidationResult("Imie i nazwisko sie pisze z duzej litery");
                }
            }
            catch (Exception e)
            {
                return new ValidationResult("że co ?? ");
                Console.WriteLine(e);
                throw;
            }
            return new ValidationResult("No nie tym razem , nie tym razem");
        }
    }
}