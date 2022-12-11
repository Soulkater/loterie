using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Partie
    {
        [Key]
        public int Id { get; set; }
        public string Guid { get; set; }
        public string GrillePartie { get; set; }

        #region cle etrangere de la table "Tirage"
        public int? TirageId { get; set; }
        public Tirage Tirage { get; set; }

        public static implicit operator string?(Partie? v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
