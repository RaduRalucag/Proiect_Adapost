using Proiect_Adapost.Models.Control;

namespace Proiect_Adapost.Services.ControlService
{
    public interface IControlService 
    {
        Task CreateControl(Control control, Guid arhivaId, Guid conditielId);
        Task DeleteControl(Control control);
        Task<Control> GetControlById(Guid id);
        Task<IEnumerable<Control>> GetControls();
    }
}
