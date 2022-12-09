using DataLayer;
using DataLayer.Model;
using loterieCda.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loterieCda.Controllers
{
    public class ResultatController : Controller
    {
        // Nos variables lu est utilisee dans le constructeur
        private readonly ILogger<ResultatController> _logger;
        private readonly appDbContext _ctx;

        // Notre Constructeur
        public ResultatController(ILogger<ResultatController> logger, appDbContext ctx)
        {
            _logger = logger;
            this._ctx = ctx;
        }

        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Index(string guid)
        {
            //Récupération du dbSet Partie
            var partie = _ctx.Partie.FirstOrDefault(p => p.Guid == guid);
            //Autre manière d'ecrire une requête
            //var dbSet = _ctx.Partie.Where(p => p.Guid == guid).FirstOrDefault();

            var resultat = new LoterieViewModel
            {
                Guid = partie.Guid,
            };

            //TODO: convertion de l'objet en LoterieViewModel tel qu'attendu par la View
            //var iTest = new LoterieViewModel
            //{
            //    Guid = result
            //};

            //Renvoie de la vue avec l'objet LoterieViewModel
            return View(resultat);
        }
    }
}
