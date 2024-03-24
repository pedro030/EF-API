using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        public Task<TEntity> Add(TEntity obj);
    }
}
