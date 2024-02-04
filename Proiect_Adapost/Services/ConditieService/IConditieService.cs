using Proiect_Adapost.Models.Conditie;

namespace Proiect_Adapost.Services.ConditieService
{
    public interface IConditieService
    {
        Task CreateConditie(Conditie conditie);
        Task DeleteConditie(Conditie conditie);
        Task<Conditie> GetConditieById(Guid id);
        Task<IEnumerable<Conditie>> GetConditii();
        Task UpdateConditie(Conditie conditie);
    }
}
