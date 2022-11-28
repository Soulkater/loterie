using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Tirage
    {
        [Key]
        public int Id { get; set; }
        public string ResultatTirage { get; set; }
        public DateTime DateHeureTirage { get; set; }
        public int CagnotteTirage { get; set; }

        #region Un tirage peut avoir plusieurs partie
        public List<Partie> Partie { get; set; }
        #endregion
    }
}
