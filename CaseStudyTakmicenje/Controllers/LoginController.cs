using CaseStudyTakmicenje.Models;
using DataAccessLayer.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LoginController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {
            var administrator =unitOfWork.AdministratorRepository.SearchByUserNamePassword(login.Username, login.Password);
            if (administrator != null ) {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
