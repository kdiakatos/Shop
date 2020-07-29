using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shop.Application.Products;
using Shop.Application.Products.ViewModels;
using Shop.Database;

namespace Shop.UI.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ProductViewModel Product { get; set; }
        public IEnumerable<ProductViewModel> AllProducts { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _ctx;
        private ICreateProduct _createProduct;
        private IGetProducts _getProducts;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext ctx, ICreateProduct createProduct, IGetProducts getProducts)
        {
            _logger = logger;
            _ctx = ctx;
            _createProduct = createProduct;
            _getProducts = getProducts;
        }

        public void OnGet()
        {
            AllProducts = _getProducts.Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await _createProduct.Do(Product);
            return RedirectToPage("Index");
        }
    }
}
