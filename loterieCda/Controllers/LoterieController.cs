using DataLayer;
using DataLayer.Model;
using loterieCda.Models;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

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
            _ctx = ctx;
        }

        public ActionResult Index()
        {
            // On crée une variable qui appelle notre LoterieViewModel
            LoterieViewModel loterie = new LoterieViewModel();
            // On génère notre GUID
            loterie.Guid = Guid.NewGuid().ToString("N").Substring(0, 22);
            // On crée la date 
            loterie.DateHeureTirage = DateTime.Now;

            // On utilise une liste pour la génération de nos chiffres
            List<int> TbLoterie = new List<int>();
            int nombres;
            // Utilisation de la méthode Random pour générer aléatoirement des chiffres
            Random rdm = new Random();

            for (int i = 0; i < 6; i++)
            {
                do
                {
                    nombres = rdm.Next(1, 50);
                }
                while (TbLoterie.Contains(nombres));
                TbLoterie.Add(nombres);
            }
            string TbInString = String.Join(" ", TbLoterie);

            loterie.ResultatTirage = TbInString;

            return View(loterie);
        }

        //POST: LoterieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LoterieViewModel loterie)
        {
            try
            {
                // Les éléments de notre Table et la correspondance avec la ViewModel
                var tirage = new Tirage();
                tirage.ResultatTirage = loterie.ResultatTirage;
                tirage.DateHeureTirage = loterie.DateHeureTirage;
                
                // Ajout de la partie créé dans le DbSet correspondant
                _ctx.Tirage.Add(tirage);

                _ctx.SaveChanges(); 
                
                // Notre table Partie
                var partie = new Partie();
                partie.Guid = loterie.Guid;
                partie.GrillePartie = loterie.GrillePartie;
                partie.TirageId = tirage.Id;

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
