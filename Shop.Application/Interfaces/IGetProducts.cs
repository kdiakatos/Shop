using Shop.Application.Products.ViewModels;
using System.Collections.Generic;

namespace Shop.Application.Products
{
    public interface IGetProducts
    {
        IEnumerable<ProductViewModel> Do();
    }
}