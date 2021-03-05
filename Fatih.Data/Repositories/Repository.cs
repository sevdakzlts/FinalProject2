using Fatih.Data.Context;
using FinalProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fatih.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;

        private readonly DbSet<TEntity> _dbSet;
        public Repository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _dbSet = appDbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(ICollection<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity); 
        }

        public void DeleteRange(ICollection<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public  async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return await (filter == null ? _dbSet.ToListAsync() : _dbSet.Where(filter).ToListAsync());
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            //?
            return await _dbSet.FindAsync(filter);
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
