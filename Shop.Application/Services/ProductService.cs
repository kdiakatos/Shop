using Shop.Application.Interfaces;
using Shop.Application.Products.ViewModels;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services
{
    public class ProductService : IProductService
    {
        private ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateProductAsync(ProductModel vm)
        {
            _context.Products.Add(new Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Value = vm.Value
            });

            await _context.SaveChangesAsync();
        }

        public IEnumerable<ProductModel> GetProductsAsync()
        {
            return _context.Products.ToList().Select(x => new ProductModel
            {
                Name = x.Name,
                Description = x.Description,
                Value = x.Value
            });
        }
    }
}
