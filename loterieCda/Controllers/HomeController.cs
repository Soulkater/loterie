using loterieCda.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace loterieCda.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Loterie()
        {
            return View();
        }
        public ActionResult Regles()
        {
            return View();
        }
        public ActionResult Resultat()
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