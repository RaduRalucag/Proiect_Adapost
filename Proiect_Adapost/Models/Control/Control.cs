using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Control
{
    public class Control : BaseEntity
    {
        public string Data { get; set; }
        public Guid? ConditieId { get; set; }
        public Conditie.Conditie? Conditie { get; set; }
        public Guid? ArhivaId { get; set; }
        public Arhiva.Arhiva? Arhiva { get; set; }

    }
}
