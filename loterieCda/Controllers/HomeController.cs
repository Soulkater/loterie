using DataLayer;
using DataLayer.Model;
using loterieCda.Models;
using Microsoft.AspNetCore.Mvc;
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

        // Partie INDEX
        public IActionResult Index()
        {
            return View();
        }

        //Partie LOTERIE
        //Affiche les data en BDD
        public IActionResult Loterie()
        {
            // 
            //var tirages = _ctx.Tirage.ToList();
            //List<LoterieViewModel> tirageList = new List<LoterieViewModel>();

            //if (tirages != null)
            //{
            //    foreach (var tirage in tirages)
            //    {
            //        var TirageViewModel = new LoterieViewModel()
            //        {
            //            ResultatTirage = tirage.ResultatTirage,
            //            DateHeureTirage = tirage.DateHeureTirage,
            //            CagnotteTirage = tirage.CagnotteTirage
            //        };
            //        tirageList.Add(TirageViewModel);
            //    }
            //    return View(tirageList);
            //}
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

        public IActionResult Regles()
        {
            return View();
        }
        public IActionResult Resultat()
        {
            return View();
        }

        // Exemple d'une route personnalisee
        //[Route("tuto/{year:int}/{month:int}")]
        //public ActionResult Test(int day, int year, int month)
        //{
        //    return new ContentResult { Content = "Le tuto a été publié le " + day + "/" + month + "/" + year };
        //}

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