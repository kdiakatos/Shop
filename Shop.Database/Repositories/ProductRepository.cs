using Microsoft.EntityFrameworkCore;
using Shop.Database.Interfaces;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Database.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public Product GetProductById(int id)
        {
           return _context.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task UpdateProduct(Product product)
        {
            var x = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            _context.Products.Update(x);
            await _context.SaveChangesAsync();
        }
    }
}
