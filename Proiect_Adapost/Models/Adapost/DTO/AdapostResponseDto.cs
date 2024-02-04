namespace Proiect_Adapost.Models.Adapost.DTO
{
    public class AdapostResponseDto
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Locatie { get; set; }
        public Guid OrasId { get; set; }
        public string NumeOras { get; set; }
        public Guid ConditieId { get; set; }
        public string NumeConditie { get; set; }
    }
}
