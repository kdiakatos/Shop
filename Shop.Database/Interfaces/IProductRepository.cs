using Shop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Database.Interfaces
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
        Task<List<Product>> GetProductsAsync();
    }
}