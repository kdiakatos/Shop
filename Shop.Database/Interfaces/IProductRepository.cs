using Shop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Database.Interfaces
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
        Task<List<Product>> GetProductsAsync();
        Task DeleteProduct(int id);
        Product GetProductById(int id);
        Task UpdateProduct(Product product);
    }
}