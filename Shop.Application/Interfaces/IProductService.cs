using Shop.Application.Products.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces
{
    public interface IProductService
    {
        Task CreateProductAsync(ProductModel vm);
        IEnumerable<ProductModel> GetProductsAsync();
    }
}