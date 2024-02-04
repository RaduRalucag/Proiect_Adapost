using AutoMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Proiect_Adapost.Models.Client;
using Proiect_Adapost.Models.Client.Dto;
using Proiect_Adapost.Models.Oras.DTO;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Services.ClientService;
using Proiect_Adapost.Services.OrasService;

namespace Proiect_Adapost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController: ControllerBase
    {
        protected readonly IClientService _clientService;
        protected readonly IMapper _mapper;

        public ClientController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientResponseDto>>> GetClienti()
        {
            var clienti = await _clientService.GetClienti();
            var clientiDTO = _mapper.Map<IEnumerable<ClientResponseDto>>(clienti);
            return Ok(clientiDTO);

        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ClientResponseDto>> GetClientById(Guid id)
        {
            var client = await _clientService.GetClientById(id);
            var clientDTO = _mapper.Map<ClientResponseDto>(client);
            return Ok(clientDTO);
        }

        [HttpPost]
        public async Task<ActionResult<ClientResponseDto>> CreateClient(ClientRequestDto client)
        {
            var _client = _mapper.Map<Client>(client);
            await _clientService.CreateClient(_client);
            var _clientDTO = _mapper.Map<ClientResponseDto>(_client);
            return Ok(_clientDTO);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ClientResponseDto>> DeleteClient(Guid id)
        {
            var client = await _clientService.GetClientById(id);
            await _clientService.DeleteClient(client);
            var _clientDTO = _mapper.Map<ClientResponseDto>(client);
            return Ok(_clientDTO);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ClientResponseDto>> UpdateClient(Guid id, ClientRequestDto client)
        {
            var _client = await _clientService.GetClientById(id);
            _mapper.Map(client, _client);
            await _clientService.UpdateClient(_client);
            var _clientDTO = _mapper.Map<ClientResponseDto>(_client);
            return Ok(_clientDTO);
        }
    }
}
