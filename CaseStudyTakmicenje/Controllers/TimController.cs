using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Controllers
{
    public class TimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
