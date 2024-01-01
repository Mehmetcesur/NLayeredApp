using Business.Abstracts;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProductRequest createProductRequest)
        {
           var result = await _productService.Add(createProductRequest);
            return Ok(result);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> Get([FromQuery] PageRequest pageRequest)
        {
            var result = await _productService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet("getByProductName")]
        public async Task<IActionResult> GetByProductName(string name)
        {
            var result = await _productService.GetByProductName(name);
            return Ok(result);
        }

    }

}