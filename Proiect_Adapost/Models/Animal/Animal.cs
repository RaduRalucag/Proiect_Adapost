using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Animal
{
    public class Animal: BaseEntity
    {
        public string Tip { get; set; }
        public string Rasa { get; set; }
        public string Culoare { get; set; }

   
        public Carnet_sanatate.Carnet_sanatate Carnet_sanatate { get; set; }
    }
}
