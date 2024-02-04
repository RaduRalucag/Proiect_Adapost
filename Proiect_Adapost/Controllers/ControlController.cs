using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.Control;
using Proiect_Adapost.Models.Control.DTO;
using Proiect_Adapost.Services.ControlService;

namespace Proiect_Adapost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ControlController : ControllerBase
    {
        protected readonly IControlService _controlService;
        protected readonly IMapper _mapper;

        public ControlController(IControlService controlService, IMapper mapper)
        {
            _controlService = controlService;
            _mapper = mapper;
        }

        [HttpGet, Authorize(Roles = "User")]
        public async Task<ActionResult<IEnumerable<ControlResponseDto>>> GetControls()
        {
            var controls = await _controlService.GetControls();
            var controlsDTO = _mapper.Map<IEnumerable<ControlResponseDto>>(controls);
            return Ok(controlsDTO);

        }

        [HttpGet("{id:guid}"), Authorize(Roles = "User")]
        public async Task<ActionResult<ControlResponseDto>> GetControlById(Guid id)
        {
            var control = await _controlService.GetControlById(id);
            var controlDTO = _mapper.Map<ControlResponseDto>(control);
            return Ok(controlDTO);
        }

        [HttpPost("arhiva/{arhivaId:guid},conditie/{conditieId:guid}"), Authorize(Roles = "Admin, Inspector")]
        public async Task<ActionResult<ControlResponseDto>> CreateControl(ControlRequestDto control, Guid arhivaId, Guid conditieId)
        {
            var _control = _mapper.Map<Control>(control);
            await _controlService.CreateControl(_control, arhivaId, conditieId);
            var _controlDTO = _mapper.Map<ControlResponseDto>(_control);
            return Ok(_controlDTO);
        }

        [HttpPut("{id:guid}"), Authorize(Roles = "Admin, Inspector")]
        public async Task<ActionResult<ControlResponseDto>> UpdateControl(Guid id, ControlRequestDto control)
        {
            var _control = await _controlService.GetControlById(id);
            _mapper.Map(control, _control);
            await _controlService.UpdateControl(_control);
            var _controlDTO = _mapper.Map<ControlResponseDto>(_control);
            return Ok(_controlDTO);
        }

        [HttpDelete("{id:guid}"), Authorize(Roles = "Admin, Inspector")]
        public async Task<ActionResult<ControlResponseDto>> DeleteControl(Guid id)
        {
            var control = await _controlService.GetControlById(id);
            await _controlService.DeleteControl(control);
            var _controlDTO = _mapper.Map<ControlResponseDto>(control);
            return Ok(_controlDTO);
        }

    }
}
