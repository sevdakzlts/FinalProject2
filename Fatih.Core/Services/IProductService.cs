using Fatih.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Services
{
    public interface IProductService:IService<Product>
    {

        Task DeleteByIdAsync(int productId);


    }
}
