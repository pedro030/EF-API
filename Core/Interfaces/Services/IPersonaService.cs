using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IPersonaService
    {
        public Task<Persona> AddPersona(Persona persona);
        public Task<IEnumerable<Persona>> GetAll();
        public Task<Persona?> GetById(long id);
        public Task<Persona?> Update(Persona persona);
        public Task<int> Delete(long personaId);
    }
}
