using DataLayer;
using DataLayer.Model;
using loterieCda.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace loterieCda.Controllers
{
    public class LoterieController : Controller
    {
        // Nos variables lu est utilisee dans le constructeur
        private readonly ILogger<LoterieController> _logger;
        private readonly appDbContext _ctx;

        // Notre Constructeur
        public LoterieController(ILogger<LoterieController> logger, appDbContext ctx)
        {
            _logger = logger;
            this._ctx = ctx;
        }


        public ActionResult Index()
        {
            // On crée notre GUID
            LoterieViewModel loterie = new LoterieViewModel();
            loterie.Guid = Guid.NewGuid().ToString("N").Substring(0, 22);

            return View(loterie);
        }

        public ActionResult TrySomething()
        {
            // Je fais des tests pour les valeurs concernant le ResultatTirage
            ResultatViewModel resultat = new ResultatViewModel();
            resultat.ResultatTirage = "15,51,51,15,15,15";

            return View(resultat);
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        //POST: LoterieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LoterieViewModel loterie)
        {
            try
            {
                // Notre table Partie
                var partie = new Partie();
                // Les éléments de notre Table et la correspondance avec la ViewModel
                partie.Guid = loterie.Guid;
                partie.GrillePartie = loterie.GrillePartie;

                // Test qui non concluant
                //var tirage = new Tirage();
                //tirage.ResultatTirage = loterie.ResultatTirage;

                // Ajout de la partie créé dans le DbSet correspondant
                _ctx.Partie.Add(partie);

                // Ajout de la partie créé dans le DbSet correspondant
                //_ctx.Tirage.Add(tirage);

                //application de l'ajout en BDD
                _ctx.SaveChanges();

                return RedirectToAction(nameof(Index), "Home");
            }
            catch
            {
                return View();
            }
        }

        // J'ai voulu intégrer des valeurs dans la table Tirage ... sans succès ...
        //POST: LoterieController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(ResultatViewModel resultat)
        //{
        //    try
        //    {
        //        var tirage = new Tirage();
        //        tirage.DateHeureTirage = resultat.DateHeureTirage;
        //        tirage.ResultatTirage = resultat.ResultatTirage;

        //        _ctx.Tirage.Add(tirage);

        //        _ctx.SaveChanges();

        //        return RedirectToAction(nameof(Index), "Home");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
