using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Adapost.DTO;
using Proiect_Adapost.Services.AdapostService;

namespace Proiect_Adapost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdapostController : ControllerBase
    {
        protected readonly IAdapostService _adapostService;
        protected readonly IMapper _mapper;

        public AdapostController(IAdapostService adapostService, IMapper mapper)
        {
            _adapostService = adapostService;
            _mapper = mapper;
        }

        [HttpGet, Authorize(Roles = "User")]
        public async Task<ActionResult<AdapostResponseDto>> GetAdaposts()
        {
            var adaposts = await _adapostService.GetAdaposts();
            var adapostsDTO = _mapper.Map<IEnumerable<AdapostResponseDto>>(adaposts);
            return Ok(adapostsDTO);
        }

        [HttpGet("{id:guid}"), Authorize(Roles = "User")]
        public async Task<ActionResult<AdapostResponseDto>> GetAdapostById(Guid id)
        {
            var adapost = await _adapostService.GetAdapostById(id);
            return Ok(adapost);
        }

        [HttpPost("oras/{orasId:guid},conditie/{conditieId:guid}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<AdapostResponseDto>> CreateAdapost(AdapostRequestDto adapost, Guid orasId, Guid conditieId)
        {
            var _adapost = _mapper.Map<Adapost>(adapost);
            await _adapostService.CreateAdapost(_adapost, orasId, conditieId);
            var _adapostDTO = _mapper.Map<AdapostResponseDto>(_adapost);
            return Ok(_adapostDTO);
        }

        [HttpPut("{id:guid}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<AdapostResponseDto>> UpdateAdapost(Guid id, AdapostRequestDto adapost)
        {
            var _adapost = await _adapostService.GetAdapostById(id);
            _mapper.Map(adapost, _adapost);
            await _adapostService.UpdateAdapost(_adapost);
            var _adapostDTO = _mapper.Map<AdapostResponseDto>(_adapost);
            return Ok(_adapostDTO);
        }  

        [HttpDelete("{id:guid}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<AdapostResponseDto>> DeleteAdapost(Guid id)
        {
            var adapost = await _adapostService.GetAdapostById(id);
            await _adapostService.DeleteAdapost(adapost);
            var _adapostDTO = _mapper.Map<AdapostResponseDto>(adapost);
            return Ok(_adapostDTO);
        }

    }
}
