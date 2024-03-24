using AutoMapper;
using Core.DTOs;
using Core.Entities;

namespace API.Dependencies
{
    public class PersonaDtoMappingProfile:Profile
    {
        public PersonaDtoMappingProfile()
        {
            CreateMap<PersonaDto, Persona>();
            CreateMap<DomicilioCreateDto, Domicilio>();
            CreateMap<PersonaDomicilioDto, Persona>();
        }
    }
}
