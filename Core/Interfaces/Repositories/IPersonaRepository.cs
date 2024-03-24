using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IPersonaRepository : IBaseRepository<Persona>
    {
        public Task<IEnumerable<Persona>> GetAll();
        public Task<Persona?> GetById(long id);
        public Task<Persona?> Update(Persona persona);
        public Task<int> Delete(long personaId);
    }
}
