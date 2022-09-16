﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Models
{
    public class TimViewModel
    {
        public int TimId { get; set; }
        [Required (ErrorMessage = "Naziv tima je obavezan")]
        public String NazivTima { get; set; }
        public int FakultetId { get; set; }
        public List<SelectListItem> Fakulteti { get; set; }
        public int Sn { get; set; }
    }
}
