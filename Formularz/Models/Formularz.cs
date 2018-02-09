using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Formularz.Models
{
    public class Formularz
    {
        [Required]
        public string NameAndSurname { get; set; }
        [MojValidatorWieku]
        public int Age { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Context { get; set; }

    }
}