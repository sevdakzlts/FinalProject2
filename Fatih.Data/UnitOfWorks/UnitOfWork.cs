using Fatih.Data.Context;
using Fatih.Data.Repositories;
using FinalProject.Core.Repositories;
using FinalProject.Core.UnitOfWorks;
using System.Threading.Tasks;

namespace Fatih.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        AppDbContext _appDbContext;
        ProductRepository _productRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_appDbContext);

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
