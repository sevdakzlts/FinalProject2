using System;
using System.Collections.Generic;
using Fatih.Core.Models;
using Fatih.Data.Context;
using FinalProject.Core.Repositories;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Fatih.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public override Task<ICollection<Product>> GetAllAsync(Expression<Func<Product, bool>> filter = null, bool eagerLoad = false)
        {
            // Like sql queries
            var query = _appDbContext.Set<Product>().AsQueryable();

            if (eagerLoad)// 
            {
                query = query
                    .Include(e => e.ProductComments)
                    .Include(e => e.Category);
            }

            return Task.FromResult<ICollection<Product>>(filter == null ? query.ToList() : query.Where(filter).ToList());
        }

        public override Task<Product> GetAsync(Expression<Func<Product, bool>> filter, bool eagerLoad = false)
        {
            var query = _appDbContext.Set<Product>().AsQueryable();
           
            if (eagerLoad)// 
            {
                query = query
                    .Include(e => e.ProductComments)
                    .Include(e => e.Category);
            }

            return Task.FromResult<Product>(filter == null ? query.FirstOrDefault() : query.Where(filter).FirstOrDefault());
        }

        public void DeleteById(int productId)
        {
            var deletedEntity = _appDbContext.Products.FirstOrDefault(p => p.Id == productId);
            _appDbContext.Products.Remove(deletedEntity);
        }
    }
}
