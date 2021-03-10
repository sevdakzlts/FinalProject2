using Fatih.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Services
{
    public interface IProductService:IService<Product>
    {

        void DeleteById(int productId);

        Task<ICollection<Product>> GetAll(Expression<Func<Product, bool>> filter = null);
    }
}
