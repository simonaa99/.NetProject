using CaseStudyTakmicenje.Models;
using DataAccessLayer.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyTakmicenje.Controllers
{
    public class UcesceController : Controller
    {
        private readonly IUnitOfWork uow;

        public UcesceController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IActionResult Create()
        {
            UcesceViewModel model = new UcesceViewModel();
            
            model.Takmicenje = new TakmicenjeViewModel();
            model.Takmicenje.TakmicenjeId = uow.TakmicenjeRepository.GetNewId();
            model.Takmicenje.DatumOdrzavanja = DateTime.Today;
            List<Tim> timovi = uow.TimRepository.GetAll();
            model.Timovi = timovi.Select(t => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = t.NazivTima, Value = t.TimId.ToString() }).ToList();
            return View(model);
        }
        //[HttpPost]
        //public IActionResult Create([FromForm(Name = "Takmicenje")]TakmicenjeViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Create();
        //    }
        //    Takmicenje t = new Takmicenje
        //    {
        //        TakmicenjeId = model.TakmicenjeId,
        //        Tema = model.Tema,
        //        DatumOdrzavanja = model.DatumOdrzavanja,
        //    };
        //    uow.TakmicenjeRepository.Add(t);
        //    //uow.Save();
        //    foreach (TimViewModel tim in model.Timovi)
        //    {
        //        Ucesce u = new Ucesce
        //        {
        //            TakmicenjeId = model.TakmicenjeId,
        //            TimId = tim.TimId
        //        };
        //        uow.UcesceRepository.Add(u);
        //        t.Ucesca.Add(u);

        //    }
        //    uow.Save();
        //    return RedirectToAction("Index", "Takmicenje");
        //}
        [HttpPost]
        public IActionResult Create([FromForm] UcesceViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }
            Takmicenje t = new Takmicenje
            {
                TakmicenjeId = model.Takmicenje.TakmicenjeId,
                Tema = model.Takmicenje.Tema,
                DatumOdrzavanja = model.Takmicenje.DatumOdrzavanja,
            };
            uow.TakmicenjeRepository.Add(t);
            //uow.Save();
            foreach (TimViewModel tim in model.Takmicenje.Timovi)
            {
                Ucesce u = new Ucesce
                {
                    TakmicenjeId = model.Takmicenje.TakmicenjeId,
                    TimId = tim.TimId
                };
                uow.UcesceRepository.Add(u);
                t.Ucesca.Add(u);

            }
            uow.Save();
            return RedirectToAction("Index", "Takmicenje");
        }


        public IActionResult CreateUcesce([FromQuery(Name = "takmicenjeId")] int takmicenjeId,[FromQuery(Name = "timId")]int timId, [FromQuery(Name = "sn")] int number) {

            Tim t = uow.TimRepository.SearchById(new Tim { TimId = timId });
            TimViewModel model = new TimViewModel { TimId = t.TimId, NazivTima = t.NazivTima, Sn = number };

            return PartialView(model);
        }

    }

}
