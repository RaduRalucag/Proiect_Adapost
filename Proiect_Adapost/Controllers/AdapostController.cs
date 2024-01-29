﻿using AutoMapper;
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

        [HttpGet]
        public async Task<ActionResult<AdapostResponseDto>> GetAdaposts()
        {
            var adaposts = await _adapostService.GetAdaposts();
            return Ok(adaposts);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AdapostResponseDto>> GetAdapostById(Guid id)
        {
            var adapost = await _adapostService.GetOrasById(id);
            return Ok(adapost);
        }

        [HttpPost("oras/{orasId:guid}")]
        public async Task<ActionResult<AdapostResponseDto>> CreateAdapost(AdapostRequestDto adapost, Guid orasId)
        {
            var _adapost = _mapper.Map<Adapost>(adapost);
            await _adapostService.CreateAdapost(_adapost, orasId);
            var _adapostDTO = _mapper.Map<AdapostResponseDto>(_adapost);
            return Ok(_adapostDTO);
        }  

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<AdapostResponseDto>> DeleteAdapost(Guid id)
        {
            var adapost = await _adapostService.GetOrasById(id);
            await _adapostService.DeleteAdapost(adapost);
            var _adapostDTO = _mapper.Map<AdapostResponseDto>(adapost);
            return Ok(_adapostDTO);
        }

        [HttpGet("oras/{id:guid}")]
        public async Task<ActionResult<AdapostResponseDto>> GetAdapostsByOras(Guid id)
        {
            var adaposts = await _adapostService.GetAdapostsByOras(id);
            return Ok(adaposts);
        }

    }
}
