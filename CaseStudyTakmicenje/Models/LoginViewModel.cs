using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Obavezno polje")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public string Password { get; set; }
    }
}
