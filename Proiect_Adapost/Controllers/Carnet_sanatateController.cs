using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.Adapost.DTO;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Carnet_sanatate;
using Proiect_Adapost.Models.Carnet_sanatate.Dto;
using Proiect_Adapost.Services.AdapostService;
using Proiect_Adapost.Services.Carnet_sanatateService;
using Proiect_Adapost.Models.Animal.Dto;
using Proiect_Adapost.Models.Animal;
using Microsoft.AspNetCore.Authorization;

namespace Proiect_Adapost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Carnet_sanatateController: ControllerBase
    {
        protected readonly ICarnet_sanatateService _carnet_sanatateService;
        protected readonly IMapper _mapper;

        public Carnet_sanatateController(ICarnet_sanatateService carnet_sanatateService, IMapper mapper)
        {
            _carnet_sanatateService = carnet_sanatateService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<IEnumerable<Carnet_sanatateResponseDto>>> GetAllCarnet_sanatate()
        {
            var carnete_sanatate = await _carnet_sanatateService.GetAllCarnet_sanatate();
            var carnet_sanatateResponseDto = _mapper.Map<IEnumerable<Carnet_sanatateResponseDto>>(carnete_sanatate);
            return Ok(carnet_sanatateResponseDto);
        }

        [HttpGet("{id:guid}")]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<Carnet_sanatateResponseDto>> GetCarnet_sanatateById(Guid id)
        {
            var carnete_sanatate = await _carnet_sanatateService.GetAnimal(id);
            return Ok(carnete_sanatate);
        }

        [HttpPost("animal/{animalId:guid}")]
        [Authorize(Roles = "Admin, Doctor")]
        public async Task<ActionResult<Carnet_sanatateResponseDto>> CreateCarnet_sanatate(Guid animalId, Carnet_sanatateRequestDto carnet_sanatate)
        {
            var _carnet_sanatate = _mapper.Map<Carnet_sanatate>(carnet_sanatate);
            await _carnet_sanatateService.CreateCarnet_sanatate(animalId, _carnet_sanatate);
            var _carnet_sanatateDTO = _mapper.Map<Carnet_sanatateResponseDto>(_carnet_sanatate);
            return Ok(_carnet_sanatateDTO);
        }

        [HttpDelete("{id:guid}")]
        [Authorize(Roles = "Admin, Doctor")]
        public async Task<ActionResult<Carnet_sanatateResponseDto>> DeleteCarnet_sanatate(Guid id)
        {
            var carnet_sanatate = await _carnet_sanatateService.GetCarnet_sanatateById(id);
            await _carnet_sanatateService.DeleteCarnet_sanatate(carnet_sanatate);
            var carnet_sanatateResponseDto = _mapper.Map<Carnet_sanatateResponseDto>(carnet_sanatate);
            return Ok(carnet_sanatateResponseDto);
        }

        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Admin, Doctor")]
        public async Task<ActionResult<Carnet_sanatateResponseDto>> UpdateCarnet_sanatate(Guid id, Carnet_sanatateRequestDto carnet_sanatate)
        {
            var _carnet_sanatate = await _carnet_sanatateService.GetCarnet_sanatateById(id);
            _mapper.Map(carnet_sanatate, _carnet_sanatate);
            await _carnet_sanatateService.UpdateCarnet_sanatate(_carnet_sanatate);
            var _carnet_sanatateDTO = _mapper.Map<Carnet_sanatateResponseDto>(_carnet_sanatate);
            return Ok(_carnet_sanatateDTO);
        }
    }
}
