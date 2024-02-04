using Proiect_Adapost.Models.Base;

namespace Proiect_Adapost.Models.User
{
    public class User : BaseEntity
    {
        public string Nume { get; set; } = string.Empty;
        public string ParolaHash { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
        public IEnumerable<Role> Roles { get; set; }
    }
}
