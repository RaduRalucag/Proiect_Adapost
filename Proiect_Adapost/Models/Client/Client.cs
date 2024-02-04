using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.Client
{
    public class Client: BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
       
        public ICollection<AnimalClient.AnimalClient> AnimaleClienti { get; set; }
    }
}
