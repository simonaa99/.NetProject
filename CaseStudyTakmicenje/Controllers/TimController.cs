using CaseStudyTakmicenje.Filter;
using CaseStudyTakmicenje.Models;
using DataAccessLayer.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Controllers
{
    [Authorize]
    [LoggedIn]
    public class TimController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TimController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }

        [HttpGet]
        public IActionResult Index()
        {
            
            List<Tim> model = unitOfWork.TimRepository.GetAll().OfType<Tim>().ToList();
            return View(model);

        }

        public IActionResult Create()
        {
            
            TimViewModel model = new TimViewModel();
            var fakulteti = unitOfWork.FakultetRepository.GetAll();
            model.Fakulteti = fakulteti.Select(f => new SelectListItem(f.NazivFakulteta, f.FakultetId.ToString())).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create([FromForm] TimViewModel tim)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }

            unitOfWork.TimRepository.Add(new Tim
            {
                NazivTima = tim.NazivTima,
                FakultetId = tim.FakultetId,
            });
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
           
            TimViewModel model = new TimViewModel();

            Tim t = (Tim)unitOfWork.TimRepository.SearchById(new Tim { TimId = id });

            model.NazivTima = t.NazivTima;
            model.FakultetId = t.FakultetId;
            var fakulteti = unitOfWork.FakultetRepository.GetAll();
            model.Fakulteti = fakulteti.Select(f => new SelectListItem(f.NazivFakulteta, f.FakultetId.ToString())).ToList();
           


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, TimViewModel tim)
        {
            unitOfWork.TimRepository.Update(new Tim
            {
                TimId = id,
                NazivTima = tim.NazivTima,
                FakultetId = tim.FakultetId,
            });
            unitOfWork.Save();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            
            TimViewModel model = new TimViewModel();

            Tim t = (Tim)unitOfWork.TimRepository.SearchById(new Tim { TimId = id });

            model.NazivTima = t.NazivTima;
            model.FakultetId = t.FakultetId;
            var fakulteti = unitOfWork.FakultetRepository.GetAll();
            model.Fakulteti = fakulteti.Select(f => new SelectListItem(f.NazivFakulteta, f.FakultetId.ToString())).ToList();


            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id, TimViewModel tim)
        {
            unitOfWork.TimRepository.Delete(new Tim
            {
                TimId = id,
                NazivTima = tim.NazivTima,
                FakultetId = tim.FakultetId,
            });
            unitOfWork.Save();

            return RedirectToAction("Index");
        }


    }
}
