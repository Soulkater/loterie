//using DataLayer;
//using loterieCda.Controllers;
//using loterieCda.Models;
//using loterieCda.Services.Interfaces;
//using System;

//namespace loterieCda.Services
//{
//    public class ResultatService : IResultatService
//    {
//        // Nos variables lu est utilisee dans le constructeur
//        private readonly ILogger<ResultatService> _logger;
//        private readonly appDbContext _ctx;

//        // Notre Constructeur
//        public ResultatService(ILogger<ResultatService> logger, appDbContext ctx)
//        {
//            _logger = logger;
//            _ctx = ctx;
//        }

//        public string Requete(string guid, string resultat)
//        {
//            // Retourne le premier élément d'une séquence, on récupère le GUID
//            var partie = _ctx.Partie.FirstOrDefault(p => p.Guid == guid);

//            // 
//            var tirage = _ctx.Tirage.Where(ligne => ligne.Id.Equals(partie.TirageId))
//                                    .FirstOrDefault();

//            var resultat = new ResultatViewModel
//            {
//                Guid = partie.Guid,
//                GrillePartie = partie.GrillePartie,
//                ResultatTirage = tirage.ResultatTirage
//            };

//            return resultat;
//        }
//    }
//}