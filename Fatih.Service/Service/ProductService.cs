using Fatih.Core.Models;
using FinalProject.Core.Repositories;
using FinalProject.Core.Services;
using FinalProject.Core.UnitOfWorks;

namespace Fatih.Service.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork,IRepository<Product> repository):base(unitOfWork,repository)
        {

        }
        public void DeleteById(int productId)
        {
              _unitOfWork.Products.DeleteById(productId);
        }
    }
}
