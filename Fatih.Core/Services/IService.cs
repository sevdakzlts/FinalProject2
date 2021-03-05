using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Services
{
    public interface IService<TEntity>
    {

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null);

        Task AddAsync(TEntity entity);
        Task AddRangeAsync(ICollection<TEntity> entities);

        Task<TEntity> UpdateAsync(TEntity entity);

        void DeleteAsync(TEntity entity);

        void DeleteRangeAsync(ICollection<TEntity> entities);
    }
}
