using FinalProject.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fatih.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name =nameof(Get))]
        public async Task<IActionResult> Get()
        {
            var res = await _productService.GetAllAsync();
            return  Ok(res);
        }


    }
}
