using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Interfaces;
using Shop.Application.Models;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        public AdminController(IProductService productService)
        {
            _productService = productService;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet("products")]
        public  IActionResult GetAllProducts()
        {
            return Ok( _productService.GetProductsAsync());
        }

        [HttpGet("products/{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(_productService.GetProductById(id));
        }

        [HttpPost("products")]
        public IActionResult CreateProduct(ProductModel productModel)
        {
            return Ok( _productService.CreateProductAsync(productModel));
        }

        [HttpDelete("products/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok(_productService.DeleteProduct(id));
        }

        [HttpPut("products")]
        public IActionResult UpdateProduct(ProductModel productModel)
        {
            return Ok(_productService.UpdateProduct(productModel));
        }
    }
}
