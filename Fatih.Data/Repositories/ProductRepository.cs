using Fatih.Core.Models;
using Fatih.Data.Context;
using FinalProject.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Fatih.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext _appDbContext { get => _appDbContext as AppDbContext; }

        public ProductRepository(AppDbContext appDbContext):base(appDbContext)
        {
           
        }
        public void DeleteById(int productId)
        {
            var deletedEntity = _appDbContext.Products.FirstOrDefault(p => p.Id == productId);
            _appDbContext.Products.Remove(deletedEntity);
        }
    }
}
