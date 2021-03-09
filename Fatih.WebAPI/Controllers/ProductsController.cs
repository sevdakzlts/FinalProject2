using FinalProject.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fatih.Core.Models;
using Fatih.Data.Repositories;

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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var res = await _productService.GetAsync(product => product.Id == id, true);
            return Ok(res);
        }

        [HttpGet(Name =nameof(Get))]
        public async Task<IActionResult> Get()
        {
            var res = await _productService.GetAllAsync(null,true);
            return  Ok(res);
        }


    }
}
