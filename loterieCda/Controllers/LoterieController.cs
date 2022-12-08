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
            return View();
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

                // On cherche le set objet Partie, puis on ajoute l'objet au dbset
                _ctx.Set<Partie>().Add(partie);
                _ctx.SaveChanges();

                var query = _ctx.Set<Partie>().AsQueryable();

                query = query.Where(p => p.Guid == partie.Guid);

                query = query.Include(p => p.Tirage);

                var result = query.ToList();


                return RedirectToAction(nameof(Index), "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
