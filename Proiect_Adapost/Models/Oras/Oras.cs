using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Orase
{
    public class Oras : BaseEntity
    {
        public string Nume { get; set; }
        public ICollection<Adapost.Adapost>? Adaposts { get; set; }
    }
}
