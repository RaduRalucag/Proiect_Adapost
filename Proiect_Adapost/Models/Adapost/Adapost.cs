using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Adapost
{
    public class Adapost : BaseEntity
    {
        public string Nume { get; set; }
        public string Locatie { get; set; }
        public Guid OrasId { get; set; }
        public Orase.Oras Oras { get; set; }
    }
}
