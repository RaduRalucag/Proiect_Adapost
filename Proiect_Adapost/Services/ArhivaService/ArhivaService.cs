using Proiect_Adapost.Models.Arhiva;
using Proiect_Adapost.Repositories.ArhivaRepository;

namespace Proiect_Adapost.Services.ArhivaService
{
    public class ArhivaService : IArhivaService
    {
        private readonly IArhivaRepository _arhivaRepository;

        public ArhivaService(IArhivaRepository arhivaRepository)
        {
            _arhivaRepository = arhivaRepository;
        }

        public async Task CreateArhiva(Arhiva arhiva)
        {
            await _arhivaRepository.CreateAsync(arhiva);
            await _arhivaRepository.SaveAsync();
        }

        public async Task DeleteArhiva(Arhiva arhiva)
        {
            _arhivaRepository.Delete(arhiva);
            await _arhivaRepository.SaveAsync();
        }

        public async Task<Arhiva> GetArhivaById(Guid id)
        {
            return await _arhivaRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Arhiva>> GetArhiva()
        {
            return await _arhivaRepository.GetAllAsync();
        }

    }
}
