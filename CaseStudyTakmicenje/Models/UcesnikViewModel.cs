using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Models
{
    public class UcesnikViewModel : IValidatableObject
    {
        public int UcesnikId { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public String Ime { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public String Prezime { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public String JMBG { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public String Kontakt { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        [Range(1,10)]
        public int GodinaStudija { get; set; }
        public int MestoId { get; set; }
        public List<SelectListItem> Mesta { get; set; }
        public int TimId { get; set; }
        public List<SelectListItem> Timovi { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new List<ValidationResult>();
            if (JMBG.Length == 0)
            {
                result.Add(new ValidationResult("JMBG mora da ima tačno 13 brojeva!"));

            }
            if (!JMBG.All(char.IsDigit)) {
                result.Add(new ValidationResult("JMBG mora da se sastoji samo od brojeva!"));
            }
            if (!Kontakt.All(char.IsDigit))
            {
                result.Add(new ValidationResult("Kontakt mora da se sastoji samo od brojeva!"));
            }
            return result;
        }
    }
}
