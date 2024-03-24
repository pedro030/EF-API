using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/personas")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;
        private readonly IMapper _mapper;
        private readonly ILogger<PersonaController> _logger;

        public PersonaController(IPersonaService personaService, IMapper mapper, ILogger<PersonaController> logger)
        {
            _personaService = personaService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonaDto personaDto)
        {
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);
                var result = await _personaService.AddPersona(persona); 
                if (result != null)
                    return Ok();
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar Persona");
                return StatusCode(500);
            }
        }
        [HttpPost("personaDomicilio")]
        public async Task<ActionResult> AddPersonaDomicilio([FromBody] PersonaDomicilioDto personaDto)
        {
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);
                var result = await _personaService.AddPersona(persona);
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar Persona");
                return StatusCode(500);
            }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetAll()
        {
            try
            {
                var result = await _personaService.GetAll();
                return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obterner Personas");
                return StatusCode(500);
            }
        }

        [HttpGet("{personaId:long}")]
        public async Task<ActionResult<Persona>> GetById(long personaId)
        {
            try
            {
                var result = await _personaService.GetById(personaId);
                if (result != null) return Ok(result);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener Persona");
                return StatusCode(500);
            }
        }
        [HttpPut("{personaId:long}")]
        public async Task<ActionResult<Persona>> Update(long personaId, PersonaDto personaDto)
        {
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);
                persona.Id = personaId;
                var result = await _personaService.Update(persona);
                if (result != null) return Ok(result);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar Persona");
                return StatusCode(500);
            }
        }
        [HttpDelete("{personaId:long}")]
        public async Task<ActionResult> Delete(long personaId)
        {
            try
            {
                var eliminado = await _personaService.Delete(personaId);
                if (eliminado == 0) return NotFound();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar Persona");
                return StatusCode(500);
            }
        }
    }
}
