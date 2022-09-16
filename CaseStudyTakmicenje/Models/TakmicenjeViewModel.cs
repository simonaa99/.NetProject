 using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Models
{
    public class TakmicenjeViewModel:IValidatableObject
    {
        public int TakmicenjeId { get; set; }
        [Required (ErrorMessage = "Polje tema je obavezno!")]
        public String Tema { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public List<TimViewModel> Timovi { get; set; } = new List<TimViewModel>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new List<ValidationResult>();
            if (Timovi.Count() == 0)
            {
                result.Add(new ValidationResult("Na takmičenju mora da učestvuje barem jedan tim!"));

            }
            return result;
        }
    }
}
