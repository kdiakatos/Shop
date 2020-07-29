using Shop.Application.Products.ViewModels;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products
{
    public class CreateProduct : ICreateProduct
    {
        private ApplicationDbContext _context;

        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel vm)
        {
            _context.Products.Add(new Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Value = vm.Value
            });

            await _context.SaveChangesAsync();
        }
    }
}
