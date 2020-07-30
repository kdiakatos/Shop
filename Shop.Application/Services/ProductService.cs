using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Interfaces;
using Shop.Application.Models;
using Shop.Database;
using Shop.Database.Interfaces;
using Shop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task CreateProductAsync(ProductModel product)
        {
            var result = _mapper.Map<Product>(product);
            await _productRepository.CreateProductAsync(result);
        }

        public async Task<List<ProductModel>> GetProductsAsync()
        {

            var ret = await _productRepository.GetProductsAsync();
            var result = _mapper.Map<List<ProductModel>>(ret);
            return result;

        }



        //private ApplicationDbContext _context;

        //public ProductService(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //public async Task CreateProductAsync(ProductModel vm)
        //{
        //    _context.Products.Add(new Product
        //    {
        //        Name = vm.Name,
        //        Description = vm.Description,
        //        Value = vm.Value
        //    });

        //    await _context.SaveChangesAsync();
        //}

        //public IEnumerable<ProductModel> GetProductsAsync()
        //{
        //    return _context.Products.ToList().Select(x => new ProductModel
        //    {
        //        Name = x.Name,
        //        Description = x.Description,
        //        Value = x.Value
        //    });
        //}
    }
}
