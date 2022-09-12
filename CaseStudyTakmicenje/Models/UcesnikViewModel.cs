using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Models
{
    public class UcesnikViewModel
    {
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

    }
}
