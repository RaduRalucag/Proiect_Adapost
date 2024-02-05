using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.AnimalClient;
using Proiect_Adapost.Models.AnimalClient.Dto;
using Proiect_Adapost.Models.Conditie.DTO;
using Proiect_Adapost.Services.AnimalClientService;

namespace Proiect_Adapost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalClientController: ControllerBase
    {
        protected readonly IAnimalClientService _animalclientService;
        protected readonly IMapper _mapper;

        public AnimalClientController(IAnimalClientService animalclientService, IMapper mapper)
        {
            _animalclientService = animalclientService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<IEnumerable<AnimalClientResponseDto>>> GetAnimalsClients()
        {
            var animalsclients = await _animalclientService.GetAnimalsClients();
            var animalsclientsDTO = _mapper.Map<IEnumerable<AnimalClientResponseDto>>(animalsclients);
            return Ok(animalsclientsDTO);

        }

        [HttpGet("{id:guid}")]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<AnimalClientResponseDto>> GetAnimalClientById(Guid id)
        {
            var animalclient = await _animalclientService.GetAnimalClientById(id);
            var animalclientDTO = _mapper.Map<AnimalClientResponseDto>(animalclient);
            return Ok(animalclientDTO);
        }

        [HttpPost("animal/{animalId:guid},client/{clientId:guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<AnimalClientResponseDto>> CreateAnimalClient(AnimalClientRequestDto animalclient, Guid animalId, Guid clientId)
        {
            var _animalclient = _mapper.Map<AnimalClient>(animalclient);
            await _animalclientService.CreateAnimalClient(_animalclient, animalId, clientId) ;
            var _animalclientDTO = _mapper.Map<AnimalClientResponseDto>(_animalclient);
            return Ok(_animalclientDTO);
        }

        [HttpDelete("{id:guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<AnimalClientResponseDto>> DeleteAnimalClient(Guid id)
        {
            var animalclient = await _animalclientService.GetAnimalClientById(id);
            await _animalclientService.DeleteAnimalClient(animalclient);
            var _animalclientDTO = _mapper.Map<AnimalClientResponseDto>(animalclient);
            return Ok(_animalclientDTO);
        }

        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<AnimalClientResponseDto>> UpdateAnimalClient(Guid id, AnimalClientRequestDto animalclient)
        {
            var _animalclient = await _animalclientService.GetAnimalClientById(id);
            _mapper.Map(animalclient, _animalclient);
            await _animalclientService.UpdateAnimalClient(_animalclient);
            var _animalclientDTO = _mapper.Map<AnimalClientResponseDto>(_animalclient);
            return Ok(_animalclientDTO);
        }
    }
}
