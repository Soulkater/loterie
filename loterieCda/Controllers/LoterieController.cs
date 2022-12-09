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
            LoterieViewModel loterie = new LoterieViewModel();
            loterie.Guid = Guid.NewGuid().ToString("N").Substring(0, 22);

            return View(loterie);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: LoterieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LoterieViewModel loterie)
        {
            try
            {
                var partie = new Partie();
                partie.Guid = loterie.Guid;
                partie.GrillePartie = loterie.GrillePartie;

                // Ajout de la partie créé dans le DbSet correspondant
                _ctx.Partie.Add(partie);

                //application de l'ajout en BDD
                _ctx.SaveChanges();

                return RedirectToAction(nameof(Index), "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
