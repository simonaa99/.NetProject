using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Models
{
    public class UcesceViewModel
    {
        public TakmicenjeViewModel Takmicenje { get; set; }
        public List<SelectListItem> Timovi { get; set; }
    }
}
