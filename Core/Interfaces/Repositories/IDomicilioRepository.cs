using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IDomicilioRepository : IBaseRepository<Domicilio>
    {
        public Task<Domicilio?> Update(Domicilio domicilio);
        public Task<int> Delete(long domicilioId);
    }
}
