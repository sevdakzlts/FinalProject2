using FinalProject.Core.Repositories;
using System.Threading.Tasks;

namespace FinalProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        //ICategoryRepository Categories { get; }

        Task CommitAsync();
        void Commit();

    }
}
