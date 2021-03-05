using Fatih.Core.Models;
using System.Threading.Tasks;

namespace FinalProject.Core.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {

        // bu sınıfa özel metodları yaz .

        void DeleteById(int productId);

    }
}
