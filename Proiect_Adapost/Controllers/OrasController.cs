using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.Oras.DTO;
using Proiect_Adapost.Models.Oras;
using Proiect_Adapost.Services.OrasService;
using Proiect_Adapost.Models.Orase;

namespace Proiect_Adapost.Controllers
{
        [Route("[controller]")]
        [ApiController]
        public class OrasController : ControllerBase
        {
            protected readonly IOrasService _orasService;
            protected readonly IMapper _mapper;

            public OrasController(IOrasService orasService, IMapper mapper)
            {
                _orasService = orasService;
                _mapper = mapper;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<OrasResponseDto>>> GetOrase()
            {
                var orase = await _orasService.GetOrase();
                var oraseDTO = _mapper.Map<IEnumerable<OrasResponseDto>>(orase);
                return Ok(oraseDTO);

            }

            [HttpGet("{id:guid}")]
            public async Task<ActionResult<OrasResponseDto>> GetOrasById(Guid id)
            {
                var oras = await _orasService.GetOrasById(id);
                var orasDTO = _mapper.Map<OrasResponseDto>(oras);
                return Ok(orasDTO);
            }

            [HttpPost]
            public async Task<ActionResult<OrasResponseDto>> CreateOras(OrasRequestDto oras)
            {
                var _oras = _mapper.Map<Oras>(oras);
                await _orasService.CreateOras(_oras);
                var _orasDTO = _mapper.Map<OrasResponseDto>(_oras);
                return Ok(_orasDTO);
            }

            [HttpDelete("{id:guid}")]
            public async Task<ActionResult<OrasResponseDto>> DeleteOras(Guid id)
            {
                var oras = await _orasService.GetOrasById(id);
                await _orasService.DeleteOras(oras);
                var _orasDTO = _mapper.Map<OrasResponseDto>(oras);
                return Ok(_orasDTO);
            }
        }
 }
