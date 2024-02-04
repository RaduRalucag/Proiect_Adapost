using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.Arhiva;
using Proiect_Adapost.Models.Arhiva.DTO;
using Proiect_Adapost.Services.ArhivaService;

namespace Proiect_Adapost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArhivaController : ControllerBase
    {
        protected readonly IArhivaService _arhivaService;
        protected readonly IMapper _mapper;

        public ArhivaController(IArhivaService arhivaService, IMapper mapper)
        {
            _arhivaService = arhivaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArhivaResponseDto>>> GetArhiva()
        {
            var arhiva = await _arhivaService.GetArhiva();
            var arhivaDTO = _mapper.Map<IEnumerable<ArhivaResponseDto>>(arhiva);
            return Ok(arhivaDTO);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ArhivaResponseDto>> GetArhivaById(Guid id)
        {
            var arhiva = await _arhivaService.GetArhivaById(id);
            var arhivaDTO = _mapper.Map<ArhivaResponseDto>(arhiva);
            return Ok(arhivaDTO);
        }

        [HttpPost]
        public async Task<ActionResult<ArhivaResponseDto>> CreateArhiva(ArhivaRequestDto arhiva)
        {
            var _arhiva = _mapper.Map<Arhiva>(arhiva);
            await _arhivaService.CreateArhiva(_arhiva);
            var _arhivaDTO = _mapper.Map<ArhivaResponseDto>(_arhiva);
            return Ok(_arhivaDTO);
        }

        private ActionResult<ArhivaResponseDto> Ok(ArhivaResponseDto arhivaDTO)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ArhivaResponseDto>> UpdateArhiva(Guid id, ArhivaRequestDto arhiva)
        {
            var _arhiva = await _arhivaService.GetArhivaById(id);
            _mapper.Map(arhiva, _arhiva);
            await _arhivaService.UpdateArhiva(_arhiva);
            var _arhivaDTO = _mapper.Map<ArhivaResponseDto>(_arhiva);
            return Ok(_arhivaDTO);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ArhivaResponseDto>> DeleteArhiva(Guid id)
        {
            var arhiva = await _arhivaService.GetArhivaById(id);
            await _arhivaService.DeleteArhiva(arhiva);
            return Ok(arhiva);
        }
    }
}
