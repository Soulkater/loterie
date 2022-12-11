using DataLayer;
using DataLayer.Model;
using loterieCda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace loterieCda.Controllers
{
    public class HomeController : Controller
    {
        // Nos variables lu est utilisee dans le constructeur
        private readonly ILogger<HomeController> _logger;
        private readonly appDbContext _ctx;

        // Notre Constructeur
        public HomeController(ILogger<HomeController> logger, appDbContext ctx)
        {
            _logger = logger;
            this._ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Loterie(LoterieViewModel LoterieDonnee)
        {
            if (ModelState.IsValid)
            {
                //
                var partie = new Partie()
                {
                    GrillePartie = LoterieDonnee.GrillePartie,
                };

                _ctx.Partie.Add(partie);
                _ctx.SaveChanges();
                TempData["successMessage"] = "Good";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["errorMessage"] = "Rong";
                return View();
            }
        }

        // Initialement c'était la ...
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}