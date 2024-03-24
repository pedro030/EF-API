using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IDomicilioService
    {
        public Task<Domicilio> AddDomicilio(Domicilio domicilio);
        public Task<Domicilio?> Update(Domicilio domicilio);
        public Task<int> Delete(long domicilioId);
    }
}
