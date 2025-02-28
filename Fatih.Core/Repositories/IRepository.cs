﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {

        Task<TEntity> GetAsync(Expression<Func<TEntity,bool>> filter );
        Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter=null);

        Task AddAsync(TEntity entity);
        Task AddRangeAsync(ICollection<TEntity> entities);

        TEntity Update(TEntity entity);

        void Delete(TEntity entity);

        void DeleteRange(ICollection<TEntity> entities);
    }
}
