using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekat.Models;
using Projekat.ViewModels;


namespace Projekat.Controllers
{
    public class UnosController : Controller
    {
        // GET: Unos
        private ApplicationDbContext _context;
        /*public ActionResult New()
        {
            var tipoviKontTel = _context.TipoviKontaktTelefona.ToList();
            var viewModel = new ViewModel
            {
                TipoviKontaktTelefon = tipoviKontTel
            };
            return View(viewModel);
        }*/
        public UnosController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var osobe = _context.Osobe.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Unos()
        {

            var tipoviKontTel = _context.TipoviKontaktTelefona.ToList();
            var poloviOs = _context.PoloviOsoba.ToList();
            var tipoviMejl = _context.TipoviMejla.ToList();
            var tipoviAdrs = _context.TipoviPttAdrese.ToList();
            var viewModel = new ViewModel
            {
                TipoviKontaktTelefon = tipoviKontTel,
                TipoviMejla = tipoviMejl,
                TipoviAdresa = tipoviAdrs,
                PoloviOsobe = poloviOs
            };
            
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Unos(ViewModel mamba)
        {
            _context.Osobe.Add(mamba.Osoba);
            _context.PoloviOsoba.Add(mamba.PolOsobe);
            _context.Stanovanja.Add(mamba.Stanovanje);

            _context.Gradovi.Add(mamba.Grad);
            _context.Opstine.Add(mamba.Opstina);
            _context.Mesta.Add(mamba.Mesto);

            _context.KontaktTelefoni.Add(mamba.KontaktTelefon);
            _context.Mejlovi.Add(mamba.Mejl);
            _context.PttAdrese.Add(mamba.PttAdresa);

            _context.TipoviKontaktTelefona.Add(mamba.TipKontaktTelefon);
            _context.TipoviMejla.Add(mamba.TipMejl);
            _context.TipoviPttAdrese.Add(mamba.TipPttAdrese);
            
            return View();
        }

    }
}