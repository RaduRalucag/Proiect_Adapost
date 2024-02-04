namespace Proiect_Adapost.Models
{
    public class RefreshToken
    {
        public required string Token { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
