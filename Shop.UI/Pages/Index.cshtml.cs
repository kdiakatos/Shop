using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shop.Application.Interfaces;
using Shop.Application.Products;
using Shop.Application.Products.ViewModels;
using Shop.Database;

namespace Shop.UI.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ProductModel Product { get; set; }
        public IEnumerable<ProductModel> AllProducts { get; set; }

        private IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
            AllProducts = _productService.GetProductsAsync();
        }

        public async Task<IActionResult> OnPost()
        {
            await _productService.CreateProductAsync(Product);
            return RedirectToPage("Index");
        }
    }
}
