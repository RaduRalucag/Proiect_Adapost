using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Control;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.ControlRepository
{
    public class ControlRepository : GenericRepository<Control>, IControlRepository
    {
        public ControlRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
