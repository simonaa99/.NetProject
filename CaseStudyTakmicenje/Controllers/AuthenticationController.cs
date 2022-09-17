using CaseStudyTakmicenje.Models;
using DataAccessLayer.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<Administrator> manager;
        private readonly SignInManager<Administrator> signInManager;

        public AuthenticationController(UserManager<Administrator> manager, SignInManager<Administrator> signInManager)
        {
            this.manager = manager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm]RegisterViewModel register)
        {
            Administrator a = new Administrator
            {
                Email = register.Email,
                UserName = register.Username,
                Ime = register.FirstName,
                Prezime = register.LastName,
            };
            var result = await manager.CreateAsync(a, register.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            else
            {
                if (result.Errors.Any(e => e.Code == "DuplicateUserName"))
                    ModelState.AddModelError("Username", result.Errors.FirstOrDefault(e => e.Code == "DuplicateUserName")?.Description);
                if (result.Errors.Any(e => e.Code.Contains("Password")))
                    ModelState.AddModelError("Password", result.Errors.FirstOrDefault(e => e.Code.Contains("Password"))?.Description);
                return View();
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginViewModel login)
        {
            var result = await signInManager.PasswordSignInAsync(login.Username, login.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Forbidden()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
