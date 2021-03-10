using Fatih.Core.Models;
using Fatih.Data.Context;
using FinalProject.Core.Repositories;
using FinalProject.Core.Services;
using FinalProject.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Fatih.Service.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly AppDbContext _dbContext;
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository, AppDbContext dbContext) : base(unitOfWork, repository)
        {
            _dbContext = dbContext;
        }
        public void DeleteById(int productId)
        {
            _unitOfWork.Products.DeleteById(productId);
        }

        public async Task<ICollection<Product>> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return await _dbContext.Products.Include(prop => prop.Category).Include(p=>p.ProductComments).ToListAsync();
        }
    }
}
