using FinalProject.Core.Repositories;
using FinalProject.Core.Services;
using FinalProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Fatih.Service.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        public IUnitOfWork _unitOfWork;
        IRepository<TEntity> _repository;
        public Service(IUnitOfWork unitOfWork,IRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public async Task AddAsync(TEntity entity)
        {
             await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task AddRangeAsync(ICollection<TEntity> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public void DeleteRange(ICollection<TEntity> entities)
        {
            _repository.DeleteRange(entities);
            _unitOfWork.Commit();
        }

        public async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return await _repository.GetAllAsync(filter);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _repository.GetAsync(filter);
        }

        public TEntity Update(TEntity entity)
        {
            var updatedEntity = _repository.Update(entity);
            _unitOfWork.Commit();
            return updatedEntity;
        }
    }
}
