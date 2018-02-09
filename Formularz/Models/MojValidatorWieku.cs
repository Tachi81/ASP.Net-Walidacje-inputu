using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formularz.Models
{
    public class MojValidatorWieku : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                int.Parse(value.ToString());
                return (int) value >= 18 ? ValidationResult.Success : new ValidationResult("Masz za mało lat");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}