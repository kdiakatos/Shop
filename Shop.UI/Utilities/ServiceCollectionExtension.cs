using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Interfaces;
using Shop.Application.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Services
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureScopedSerivces(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductService, ProductService>();
        }
    }
}
