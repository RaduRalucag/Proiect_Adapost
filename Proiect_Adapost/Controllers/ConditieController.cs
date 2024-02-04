using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.Conditie;
using Proiect_Adapost.Models.Conditie.DTO;
using Proiect_Adapost.Services.ConditieService;

namespace Proiect_Adapost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConditieController : ControllerBase
    {
        protected readonly IConditieService _conditieService;
        protected readonly IMapper _mapper;

        public ConditieController(IConditieService conditieService, IMapper mapper)
        {
            _conditieService = conditieService;
            _mapper = mapper;
        }

        [HttpGet, Authorize(Roles = "User")]

        public async Task<ActionResult<IEnumerable<ConditieResponseDto>>> GetConditii()
        {
            var conditii = await _conditieService.GetConditii();
            var conditiiDTO = _mapper.Map<IEnumerable<ConditieResponseDto>>(conditii);
            return Ok(conditiiDTO);

        }

        [HttpGet("{id:guid}"), Authorize(Roles = "User")]
        public async Task<ActionResult<ConditieResponseDto>> GetConditieById(Guid id)
        {
            var conditie = await _conditieService.GetConditieById(id);
            var conditieDTO = _mapper.Map<ConditieResponseDto>(conditie);
            return Ok(conditieDTO);
        }

        [HttpPost, Authorize(Roles = "Admin, Inspector")]
        public async Task<ActionResult<ConditieResponseDto>> CreateConditie(ConditieRequestDto conditie)
        {
            var _conditie = _mapper.Map<Conditie>(conditie);
            await _conditieService.CreateConditie(_conditie);
            var _conditieDTO = _mapper.Map<ConditieResponseDto>(_conditie);
            return Ok(_conditieDTO);
        }

        [HttpPut("{id:guid}"), Authorize(Roles = "Admin, Inspector")]  
        public async Task<ActionResult<ConditieResponseDto>> UpdateConditie(Guid id, ConditieRequestDto conditie)
        {
            var _conditie = await _conditieService.GetConditieById(id);
            _mapper.Map(conditie, _conditie);
            await _conditieService.UpdateConditie(_conditie);
            var _conditieDTO = _mapper.Map<ConditieResponseDto>(_conditie);
            return Ok(_conditieDTO);
        }

        [HttpDelete("{id:guid}"), Authorize(Roles = "Admin, Inspector")]
        public async Task<ActionResult<ConditieResponseDto>> DeleteConditie(Guid id)
        {
            var conditie = await _conditieService.GetConditieById(id);
            await _conditieService.DeleteConditie(conditie);
            var _conditieDTO = _mapper.Map<ConditieResponseDto>(conditie);
            return Ok(_conditieDTO);
        }
    }
}
