using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Carnet_sanatate;

namespace Proiect_Adapost.Services.Carnet_sanatateService
{
    public interface ICarnet_sanatateService
    {
        Task<IEnumerable<Carnet_sanatate>> GetAllCarnet_sanatate();
        Task CreateCarnet_sanatate(Guid animalId, Carnet_sanatate carnet_sanatate);
        Task DeleteCarnet_sanatate(Carnet_sanatate carnet_sanatate);
        Task<Carnet_sanatate> GetCarnet_sanatateById(Guid id);
        Task<Carnet_sanatate> GetAnimal(Guid id);

        Task UpdateCarnet_sanatate(Carnet_sanatate carnet_sanatate);

    }
}
