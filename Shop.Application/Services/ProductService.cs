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

        public ProductModel GetProductById(int id)
        {
            var get = _productRepository.GetProductById(id);
            var result = _mapper.Map<ProductModel>(get);
            return result;
        }

        public async Task DeleteProduct(int id)
        {
            await _productRepository.DeleteProduct(id);
        }

        public async Task UpdateProduct(ProductModel product)
        {
            var x = _mapper.Map<Product>(product);
            await _productRepository.UpdateProduct(x);
        }
    }
}
