using DataLayer.Model;

namespace loterieCda.Models

{
    public class ResultatViewModel
    {
        public string Guid { get; set; }
        public DateTime DateHeureTirage { get; set; }
        public string ResultatTirage { get; set; }
        public string GrillePartie { get; set; }
        public int CagnotteTirage { get; set; }
    }
}
