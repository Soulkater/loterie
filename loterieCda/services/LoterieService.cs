//using DataLayer;
//using DataLayer.Model;
//using loterieCda.Controllers;
//using loterieCda.Models;
//using loterieCda.Services.Interfaces;

//namespace loterieCda.services
//{
//    public class LoterieService : ILoterieService
//    {
//        // Nos variables lu est utilisee dans le constructeur
//        private readonly ILogger<LoterieController> _logger;
//        private readonly appDbContext _ctx;

//        // Notre Constructeur
//        public LoterieService(ILogger<LoterieController> logger, appDbContext ctx)
//        {
//            _logger = logger;
//            _ctx = ctx;
//        }

//        public string GenererGuid()
//        {
//            return Guid.NewGuid().ToString("N").Substring(0, 22);
//        }

//        public DateTime GetDateTime()
//        {
//            return DateTime.Now;
//        }

//        public string GenererTirage()
//        {
//            //
//            List<int> TbLoterie = new List<int>();
//            int nombres;
//            //
//            Random rdm = new Random();

//            for (int i = 0; i < 6; i++)
//            {
//                do
//                {
//                    nombres = rdm.Next(1, 50);
//                }
//                while (TbLoterie.Contains(nombres));
//                TbLoterie.Add(nombres);
//            }
//            string TbInString = String.Join(" ", TbLoterie);

//            return TbInString;
//        }

//        public void Insertion(LoterieViewModel loterie)
//        {
//            // Les éléments de notre Table et la correspondance avec la ViewModel
//            var tirage = new Tirage();

//            tirage.ResultatTirage = loterie.ResultatTirage;
//            tirage.DateHeureTirage = loterie.DateHeureTirage;

//            // Ajout de la partie créé dans le DbSet correspondant
//            _ctx.Tirage.Add(tirage);

//            _ctx.SaveChanges();

//            // Notre table Partie
//            var partie = new Partie();

//            partie.Guid = loterie.Guid;
//            partie.GrillePartie = loterie.GrillePartie;
//            partie.TirageId = tirage.Id;

//            // Ajout de la partie créé dans le DbSet correspondant
//            _ctx.Partie.Add(partie);

//            //application de l'ajout en BDD
//            _ctx.SaveChanges();
//        }
//    }
//}