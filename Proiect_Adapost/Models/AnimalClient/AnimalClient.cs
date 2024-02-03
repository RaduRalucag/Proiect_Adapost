using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.AnimalClient
{
    public class AnimalClient: BaseEntity
    {
        public Guid AnimalId { get; set; }
        public Guid ClientId { get; set; }
        public string DataAdoptie { get; set; }
        public Animal.Animal? Animal { get; set; }
        public Client.Client? Client { get; set; }
    }
}
