using CaseStudyTakmicenje.Filter;
using DataAccessLayer.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        [LoggedIn]
        public IActionResult Index()
        {
            var user = HttpContext.User;
            return View();
        }
    }
}
