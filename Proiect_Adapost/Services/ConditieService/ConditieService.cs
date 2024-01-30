using Proiect_Adapost.Models.Conditie;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Repositories.ConditieRepository;

namespace Proiect_Adapost.Services.ConditieService
{
    public class ConditieService : IConditieService
    {
        private readonly IConditieRepository _conditieRepository;

        public ConditieService(IConditieRepository conditieRepository)
        {
            _conditieRepository = conditieRepository;
        }

        public async Task CreateConditie(Conditie conditie)
        {
            await _conditieRepository.CreateAsync(conditie);
            await _conditieRepository.SaveAsync();
        }

        public async Task DeleteConditie(Conditie conditie)
        {
            _conditieRepository.Delete(conditie);
            await _conditieRepository.SaveAsync();
        }

        public async Task<Conditie> GetConditieById(Guid id)
        {
            return await _conditieRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Conditie>> GetConditii()
        {
            return (List<Conditie>)await _conditieRepository.GetAllAsync();
        }
    }
}
