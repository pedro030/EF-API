using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PersonaService:IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public async Task<Persona> AddPersona(Persona persona)
        {
            var result = await this._personaRepository.Add(persona);
            return result;
        }

        public async Task<int> Delete(long personaId)
        {
            return await this._personaRepository.Delete(personaId);
        }

        public async Task<IEnumerable<Persona>> GetAll()
        {
            return await this._personaRepository.GetAll();
        }

        public async Task<Persona?> GetById(long id)
        {
            return await this._personaRepository.GetById(id);
        }

        public async Task<Persona?> Update(Persona persona)
        {
            return await this._personaRepository.Update(persona);
        }
    }
}
