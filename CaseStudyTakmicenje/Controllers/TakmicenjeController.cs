using CaseStudyTakmicenje.Models;
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
    public class TakmicenjeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TakmicenjeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<Takmicenje> model = unitOfWork.TakmicenjeRepository.GetAll().OfType<Takmicenje>().ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            List<Ucesce> model = (List<Ucesce>)unitOfWork.UcesceRepository.GetAll(id);

            return View(model);
        }

        //public IActionResult Create()
        //{
        //    StatistikaViewModel model = new StatistikaViewModel();
        //    int idTakmicenja = unitOfWork.TakmicenjeRepository.GetNewId(new Takmicenje());
        //    model.Takmicenje = new TakmicenjeViewModel();
        //    model.Takmicenje.TakmicenjeId = idTakmicenja;
        //    var timovi = unitOfWork.TimRepository.GetAll();
        //    model.Timovi = timovi.Select(t => new SelectListItem(t.NazivTima, t.TimId.ToString())).ToList();

        //    return View(model);
        //}

        //[HttpPost]
        //public IActionResult Create([FromForm(Name = "takmicenjeId")] int id, [FromForm] List<StatistikaViewModel> lista)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return RedirectToAction("Create", "Takmicenje");
        //    }

        //    foreach (StatistikaViewModel s in lista)
        //    {
        //        unitOfWork.UcesceRepository.Add(new Ucesce
        //        {
        //            TakmicenjeId = s.Takmicenje.TakmicenjeId,
        //            TimId = s.TimId,

        //        }); ;
        //    }
        //    StatistikaViewModel zaTakm = lista[0];
        //    Takmicenje t = new Takmicenje();
        //    t.Tema = zaTakm.Takmicenje.Tema;
        //    t.DatumOdrzavanja = zaTakm.Takmicenje.DatumOdrzavanja;
        //    //da li dodati i listu statistika u takmicenje??????
        //    unitOfWork.TakmicenjeRepository.Add(t);

        //    unitOfWork.Save();
        //    return RedirectToAction("Index", "Takmicenje");
        //}
    }
}
