using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Arhiva
{
    public class Arhiva : BaseEntity
    {
        public string Categorie { get; set; }
        public string Descriere { get; set; }
        public ICollection<Control.Control>? Control { get; set; }
    }
}
