using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Animal
{
    public class Animal: BaseEntity
    {
        
        public string Nume { get; set; }
        public string Tip { get; set; }
        public string Rasa { get; set; }
        public string Culoare { get; set; }

        public Guid? AdapostId { get; set; }

   
        public Carnet_sanatate.Carnet_sanatate? Carnet_sanatate { get; set; }

        public ICollection<AnimalClient.AnimalClient>? AnimaleClienti { get; set; }

        public Adapost.Adapost? Adapost { get; set; }

    }
}
