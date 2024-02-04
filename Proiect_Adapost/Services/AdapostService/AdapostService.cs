using AutoMapper;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Repositories.AdapostRepository;
using Proiect_Adapost.Repositories.ConditieRepository;
using Proiect_Adapost.Repositories.OrasRepository;

namespace Proiect_Adapost.Services.AdapostService
{
    public class AdapostService : IAdapostService
    {
        private readonly IAdapostRepository _adapostRepository;
        private readonly IOrasRepository _orasRepository;
        private readonly IConditieRepository _conditieRepository;
        private readonly IMapper _mapper;

        public AdapostService(IAdapostRepository repository, IOrasRepository orasRepository, IConditieRepository conditieRepository, IMapper mapper)
        { 
            _adapostRepository = repository;
            _orasRepository = orasRepository;
            _conditieRepository = conditieRepository;
            _mapper = mapper;
        }

        public async Task CreateAdapost(Adapost adapost, Guid orasId, Guid conditieId)
        {
            var oras = await _orasRepository.GetOrasById(orasId);
            adapost.Oras = oras;
            var conditie = await _conditieRepository.GetConditieById(conditieId);
            adapost.Conditie = conditie;
            await _adapostRepository.CreateAsync(adapost);
            await _adapostRepository.SaveAsync();

        }

        public async Task DeleteAdapost(Adapost adapost)
        {
            _adapostRepository.Delete(adapost);
            await _adapostRepository.SaveAsync();
        }

        public async Task<Adapost> GetAdapostById(Guid id)
        {
            return await _adapostRepository.GetAdapostById(id);
        }

        public async Task<List<Adapost>> GetAdaposts()
        {
            return (List<Adapost>)await _adapostRepository.GetAllAsync();
        }

        public async Task UpdateAdapost(Adapost adapost)
        {
            _adapostRepository.Update(adapost);
            await _adapostRepository.SaveAsync();
        }
    }
}
