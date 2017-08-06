using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace zengamemanifesto.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bevestig wachtwoord")]
        [Compare("Password", ErrorMessage = "De twee wachtwoorden komen niet overeen.")]
        public string Password { get; set; }
    }
}