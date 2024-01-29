using AutoMapper;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Adapost;

namespace Proiect_Adapost.Services.AdapostService
{
    public class AdapostService : IAdapostService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AdapostService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAllAdapost(IList<Adapost> adaposts)
        {
            await _context.Adaposts.AddRangeAsync(adaposts);
            await _context.SaveChangesAsync();
        }

        public async Task CreateAdapost(Adapost adapost)
        {
            await _context.Adaposts.AddAsync(adapost);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdapost(Adapost adapost)
        {
            _context.Adaposts.Remove(adapost);
            await _context.SaveChangesAsync();
        }

        public async Task<Adapost> GetAdapostById(Guid id)
        {
            return await _context.Adaposts.FirstOrDefaultAsync(adapost => adapost.Id == id);
        }

        public async Task<List<Adapost>> GetAdaposts()
        {
            return await _context.Adaposts.ToListAsync();
        }   
    }
}
