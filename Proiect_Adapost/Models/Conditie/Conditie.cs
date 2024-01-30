using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Conditie
{
    public class Conditie : BaseEntity
    {
        public string Denumire { get; set; }
        public int Gravitate { get; set; }
        public Guid AdapostId { get; set; }
        public Adapost.Adapost? Adapost { get; set; }
        public ICollection<Control.Control> Control { get; set; }
    }
}
