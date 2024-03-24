using Core.Entities;
using Infraestructure.Data;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected AppDbContext context;
        protected DbSet<TEntity> dbSet;

        public BaseRepository(AppDbContext context)
        {
            this.context = context;
            dbSet = ((DbContext)context).Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity obj)
        {
            dbSet.Add(obj);
            await context.SaveChangesAsync();
            return obj;
        }
    }
}
