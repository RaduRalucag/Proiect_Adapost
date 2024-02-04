namespace Proiect_Adapost.Models.User
{
    public class User
    {
        public string Nume { get; set; } = string.Empty;
        public string ParolaHash { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
    }
}
