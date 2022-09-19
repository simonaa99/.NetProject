using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username polje je obavezno!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password polje je obavezno!")]
        public string Password { get; set; }
    }
}
