using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Repositories.OrasRepository;

namespace Proiect_Adapost.Services.OrasService
{
    public class OrasService : IOrasService
    {
        private readonly IOrasRepository _orasRepository;

        public OrasService(IOrasRepository orasRepository)
        {
            _orasRepository = orasRepository;
        }

        public async Task CreateOras(Oras oras)
        {
            await _orasRepository.CreateAsync(oras);
            await _orasRepository.SaveAsync();
        }

        public async Task DeleteOras(Oras oras)
        {
            _orasRepository.Delete(oras);
            await _orasRepository.SaveAsync();
        }
        public async Task<Oras> GetOrasById(Guid id)
        {
            return await _orasRepository.GetOrasById(id);
        }

        public async Task<IEnumerable<Oras>> GetOrase()
        {
            
            return await _orasRepository.GetAllOraseAsync();
        }

        public async Task UpdateOras(Oras oras)
        {
            _orasRepository.Update(oras);
            await _orasRepository.SaveAsync();
        }
    }
}
