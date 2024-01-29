﻿using AutoMapper;
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
            public async Task<ActionResult<IEnumerable<OrasDto>>> GetOrase()
            {
                var orase = await _orasService.GetOrase();
                var oraseDTO = _mapper.Map<IEnumerable<OrasDto>>(orase);
                return Ok(oraseDTO);

            }

            [HttpGet("{id:guid}")]
            public async Task<ActionResult<OrasDto>> GetOrasById(Guid id)
            {
                var adapost = await _orasService.GetOrasById(id);
                return Ok(adapost);
            }

            [HttpPost]
            public async Task<ActionResult<OrasDto>> CreateOras(OrasDto oras)
            {
                var _oras = _mapper.Map<Oras>(oras);
                await _orasService.CreateOras(_oras);
                var _orasDTO = _mapper.Map<OrasDto>(_oras);
                return Ok(_orasDTO);
            }

            [HttpDelete("{id:guid}")]
            public async Task<ActionResult<OrasDto>> DeleteOras(Guid id)
            {
                var oras = await _orasService.GetOrasById(id);
                await _orasService.DeleteOras(oras);
                var _orasDTO = _mapper.Map<OrasDto>(oras);
                return Ok(_orasDTO);
            }
        }
 }
