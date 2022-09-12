﻿using CaseStudyTakmicenje.Models;
using DataAccessLayer.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Controllers
{
    public class UcesnikController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public UcesnikController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Ucesnik> model = unitOfWork.UcesnikRepository.GetAll().OfType<Ucesnik>().ToList();
            return View(model);

        }

        public IActionResult Create()
        {
            UcesnikViewModel model = new UcesnikViewModel();
            var mesta = unitOfWork.MestoRepository.GetAll();
            var timovi = unitOfWork.TimRepository.GetAll();
            model.Mesta = mesta.Select(m => new SelectListItem(m.NazivMesta, m.MestoId.ToString())).ToList();
            model.Timovi = timovi.Select(t => new SelectListItem(t.NazivTima, t.TimId.ToString())).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create([FromForm] UcesnikViewModel ucesnik)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }

            unitOfWork.UcesnikRepository.Add(new Ucesnik
            {
                Ime = ucesnik.Ime,
                Prezime = ucesnik.Prezime,
                JMBG = ucesnik.JMBG,
                GodinaStudija = ucesnik.GodinaStudija,
                Kontakt = ucesnik.Kontakt,
                MestoId = ucesnik.MestoId,
                TimId = ucesnik.TimId,
            });
            unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}