using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.Animal.Dto;
using Proiect_Adapost.Services.AnimalService;

namespace Proiect_Adapost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService, IMapper mapper)
        {
            _mapper = mapper;
            _animalService = animalService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnimalResponseDto>>> GetAllAnimals()
        {
            var animals = await _animalService.GetAllAnimals();
            var animalsResponseDto = _mapper.Map<IEnumerable<AnimalResponseDto>>(animals);
            return Ok(animalsResponseDto);
        }

        [HttpPost]
        public async Task<ActionResult<AnimalResponseDto>> CreateAnimal([FromBody] AnimalRequestDto animalRequestDto)
        {
            var animal = _mapper.Map<Animal>(animalRequestDto);
            await _animalService.CreateAnimal(animal);
            var animalResponseDto = _mapper.Map<AnimalResponseDto>(animal);
            return Ok(animalResponseDto);
        }
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AnimalResponseDto>> GetAnimal(Guid id)
        {
            var animal = await _animalService.GetAnimal(id);
            var animalResponseDto = _mapper.Map<AnimalResponseDto>(animal);
            return Ok(animalResponseDto);
        }

     
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<AnimalResponseDto>> DeleteAnimal(Guid id)
        {
            var animal = await _animalService.GetAnimal(id);
            await _animalService.DeleteAnimal(animal);
            var animalResponseDto = _mapper.Map<AnimalResponseDto>(animal);
            return Ok(animalResponseDto);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<AnimalResponseDto>> UpdateAnimal(Guid id, [FromBody] AnimalRequestDto animalRequestDto)
        {
            var animal = await _animalService.GetAnimal(id);
            _mapper.Map(animalRequestDto, animal);
            await _animalService.UpdateAnimal(animal);
            var animalResponseDto = _mapper.Map<AnimalResponseDto>(animal);
            return Ok(animalResponseDto);
        }
    }
}
