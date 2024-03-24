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
    internal class DomicilioRepository : BaseRepository<Domicilio>, IDomicilioRepository
    {
        public DomicilioRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<int> Delete(long domicilioId)
        {
            return await this.context.Domicilios.Where(d => d.Id == domicilioId).ExecuteDeleteAsync();
        }

        public async Task<Domicilio?> Update(Domicilio domicilio)
        {
            var result = this.context.Domicilios.Update(domicilio);
            await this.context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
