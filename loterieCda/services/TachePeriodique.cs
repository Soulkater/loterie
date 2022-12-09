using DataLayer;
using DataLayer.Model;

namespace loterieCda.services
{
    /// <summary>
    /// Classe qui gère la création toutes les 5 minutes d'un tirage
    /// </summary>
    public class TachePeriodique : BackgroundService
    {
        private readonly ILogger<TachePeriodique> _logger;
        private readonly appDbContext _ctx;

        public TachePeriodique(
            ILogger<TachePeriodique> logger,
            appDbContext context)
        {
            _logger = logger;
            _ctx = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stoppingToken">Token permettant l'arrêt de la tache</param>
        /// <returns></returns>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromMinutes(5));

            while (
                !stoppingToken.IsCancellationRequested &&
                await timer.WaitForNextTickAsync(stoppingToken))
            {
                var tirage = new Tirage()
                {
                    DateHeureTirage = DateTime.Now.AddMinutes(5),
                    CagnotteTirage = 10,
                };



                _ctx.SaveChanges();
            }
        }
    }
}
