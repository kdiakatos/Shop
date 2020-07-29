using Shop.Application.Products.ViewModels;
using System.Threading.Tasks;

namespace Shop.Application.Products
{
    public interface ICreateProduct
    {
        Task Do(ProductViewModel vm);
    }
}