using DataLayer.Model;

namespace loterieCda.Models

{
    public class LoterieViewModel
    {
        public string Guid { get; set; }
        public string GrillePartie { get; set; }
        public string ResultatTirage { get; set; }
        public DateTime DateHeureTirage { get; set; }
        public int CagnotteTirage { get; set; }
    }
}
