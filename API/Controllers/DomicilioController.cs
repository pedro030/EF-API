using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/domicilio")]
    public class DomicilioController : ControllerBase
    {
        private readonly IDomicilioService _domicilioService;
        private readonly IMapper _mapper;
        private readonly ILogger<DomicilioController> _logger;

        public DomicilioController(IDomicilioService domicilioService, IMapper mapper, ILogger<DomicilioController> logger)
        {
            _domicilioService = domicilioService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DomicilioCreateDto domicilioDto)
        {
            try
            {
                var domicilio = _mapper.Map<Domicilio>(domicilioDto);
                var result = await _domicilioService.AddDomicilio(domicilio);
                if (result != null)
                    return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar Domicilio");
                return StatusCode(500);
            }


        }
        [HttpPut("{domicilioId:long}")]
        public async Task<ActionResult> Put(long domicilioId, DomicilioCreateDto domicilioDto)
        {
            try
            {
                var domicilio = _mapper.Map<Domicilio>(domicilioDto);
                domicilio.Id = domicilioId;
                var result = await _domicilioService.Update(domicilio);
                if (result != null) return Ok();
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar domicilio");
                return StatusCode(500);
            }
        }
        [HttpDelete("{domicilioId:long}")]
        public async Task<ActionResult> Delete(long domicilioId)
        {
            try
            {
                var eliminado = await this._domicilioService.Delete(domicilioId);
                if (eliminado == 0) return NotFound();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al borrar domicilio");
                return StatusCode(500);
            }
        }
    }
}
