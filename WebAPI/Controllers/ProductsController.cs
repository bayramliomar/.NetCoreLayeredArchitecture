using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
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
        
        [HttpPost("addproduct")]
        public IActionResult Add(Product product)
        {
            var result= _productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("deleteproduct")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("updateproduct")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getproduct")]
        public IActionResult Get(int productId)
        {
            var result = _productService.Get(productId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getproductlist")]
        public IActionResult GetList()
        {
            var result = _productService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getproductlistbycategoryid")]
        public IActionResult GetListByCategoryId(int categoryId)
        {
            var result = _productService.GetListByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
