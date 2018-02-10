using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Formularz.Validators;

namespace Formularz.Models
{
    public class Formularz
    {
        [Required]
        [IsFirstLetterUpperCaseattribute]
        public string NameAndSurname { get; set; }
        [ValidatorOfPostCode]
        public string PostCode { get; set; }
        [MojValidatorWieku]
        public int Age { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Context { get; set; }

    }
}