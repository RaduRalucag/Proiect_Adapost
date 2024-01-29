using AutoMapper;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Repositories.AdapostRepository;
using static System.Reflection.Metadata.BlobBuilder;

namespace Proiect_Adapost.Services.AdapostService
{
    public class AdapostService : IAdapostService
    {
        private readonly IAdapostRepository _adapostRepository;
        private readonly IMapper _mapper;

        public AdapostService(IAdapostRepository repository, IMapper mapper)
        { 
            _adapostRepository = repository;
            _mapper = mapper;
        }

        public async Task CreateAdapost(Adapost adapost)
        {
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
            return await _adapostRepository.FindByIdAsync(id);
        }

        public async Task<List<Adapost>> GetAdaposts()
        {
            return (List<Adapost>)await _adapostRepository.GetAllAsync();
    }   
    }
}
