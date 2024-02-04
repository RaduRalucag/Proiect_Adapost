using Proiect_Adapost.Models.Control;
using Proiect_Adapost.Repositories.ArhivaRepository;
using Proiect_Adapost.Repositories.ConditieRepository;
using Proiect_Adapost.Repositories.ControlRepository;

namespace Proiect_Adapost.Services.ControlService
{
    public class ControlService : IControlService
    {
        private readonly IControlRepository _controlRepository;
        private readonly IArhivaRepository _arhivaRepository;
        private readonly IConditieRepository _conditieRepository;

        public ControlService(IControlRepository controlRepository, IArhivaRepository arhivaRepository, IConditieRepository conditieRepository)
        {
            _controlRepository = controlRepository;
            _arhivaRepository = arhivaRepository;
            _conditieRepository = conditieRepository;
        }

        public async Task CreateControl(Control control, Guid arhivaId, Guid conditieId)
        {
            var arhiva = await _arhivaRepository.GetArhivaById(arhivaId);
            control.Arhiva = arhiva;
            var conditie = await _conditieRepository.GetConditieById(conditieId);
            control.Conditie = conditie;
            await _controlRepository.CreateAsync(control);
            await _controlRepository.SaveAsync();

        }

        public async Task DeleteControl(Control control)
        {
            _controlRepository.Delete(control);
            await _controlRepository.SaveAsync();
        }

        public async Task<Control> GetControlById(Guid id)
        {
            return await _controlRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Control>> GetControls()
        {
            return (List<Control>)await _controlRepository.GetAllAsync();
        }

        public async Task UpdateControl(Control control)
        {
            _controlRepository.Update(control);
            await _controlRepository.SaveAsync();
        }
    }
}
