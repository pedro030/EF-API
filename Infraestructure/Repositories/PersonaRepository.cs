using Core.Entities;
using Core.Interfaces.Repositories;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class PersonaRepository : BaseRepository<Persona>, IPersonaRepository
    {
        private readonly AppDbContext _appDbContext;

        public PersonaRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Persona>> GetAll()
        {
            return await _appDbContext.Personas
                .Include(p => p.Domicilio)
                .ToListAsync();
        }
        public async Task<Persona?> GetById(long id)
        {
            var persona = await _appDbContext.Personas
                .Include(p => p.Domicilio)
                .FirstOrDefaultAsync(p => p.Id == id);
            return persona;
        }
        public async Task<Persona?> Update(Persona persona)
        {
            var personaUpdated = _appDbContext.Personas.Update(persona);
            await _appDbContext.SaveChangesAsync();
            return personaUpdated.Entity;
        }
        public async Task<int> Delete(long personaId)
        {
            var registroEliminado = await _appDbContext.Personas.Where(p => p.Id == personaId).ExecuteDeleteAsync();
            return registroEliminado;
        }
    }
}
