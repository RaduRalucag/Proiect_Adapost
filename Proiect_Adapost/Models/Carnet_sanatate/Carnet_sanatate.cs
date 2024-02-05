using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Carnet_sanatate
{
    public class Carnet_sanatate: BaseEntity
    {
        public string Vaccin { get; set; }
        public string Varsta { get; set; }

        public Guid? AnimalId { get; set; }
        public Animal.Animal? Animal { get; set; }
    }
}
