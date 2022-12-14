using DataLayer;
//using DataLayer.Model;
using loterieCda.Models;
//using Microsoft.AspNetCore.Http;
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
            _ctx = ctx;
        }

        [HttpPost]
        public IActionResult Index(string guid)
        {
            // Retourne le premier élément d'une séquence, on récupère le GUID
            var partie = _ctx.Partie.FirstOrDefault(p => p.Guid == guid);

            // 
            var tirage = _ctx.Tirage.Where(ligne => ligne.Id.Equals(partie.TirageId))
                                    .FirstOrDefault();

            var resultat = new ResultatViewModel
            {
                Guid = partie.Guid,
                GrillePartie = partie.GrillePartie,
                ResultatTirage = tirage.ResultatTirage
            };

            //Renvoie de la vue avec l'objet LoterieViewModel
            return View(resultat);
        }
    }
}
