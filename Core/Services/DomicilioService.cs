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
    internal class DomicilioService : IDomicilioService
    {
        private readonly IDomicilioRepository _repository;

        public DomicilioService(IDomicilioRepository repository)
        {
            _repository = repository;
        }

        public async Task<Domicilio> AddDomicilio(Domicilio domicilio)
        {
            var result = await this._repository.Add(domicilio);
            return result;
        }

        public Task<int> Delete(long domicilioId)
        {
            return this._repository.Delete(domicilioId);
        }

        public Task<Domicilio?> Update(Domicilio domicilio)
        {
            return this._repository.Update(domicilio);
        }
    }
}
