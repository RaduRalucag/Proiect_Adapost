﻿using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.AdapostRepository
{
    public class AdapostRepository : GenericRepository<Adapost>, IAdapostRepository
    {

        public AdapostRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Adapost> GetAdapostById(Guid adapostId)
        {
            return await _table
                .Include(a => a.Conditie)
                .Include(a => a.Oras)
                .FirstOrDefaultAsync(a => a.Id == adapostId);
        }

        public async Task<IEnumerable<Adapost>> GetAllAdapostsAsync()
        {
            return await _table
                .Include(a => a.Conditie)
                .Include(a => a.Oras)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
