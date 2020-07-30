using Shop.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces
{
    public interface IProductService
    {
        Task CreateProductAsync(ProductModel product);
        Task<List<ProductModel>> GetProductsAsync();
    }
}