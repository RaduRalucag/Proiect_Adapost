using Proiect_Adapost.Models.Arhiva;

namespace Proiect_Adapost.Services.ArhivaService
{
    public interface IArhivaService
    {
        Task CreateArhiva(Arhiva arhiva);
        Task DeleteArhiva(Arhiva arhiva);
        Task<Arhiva> GetArhivaById(Guid id);
        Task<IEnumerable<Arhiva>> GetArhiva();

    }
}
