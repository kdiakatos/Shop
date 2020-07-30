using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Interfaces;
using Shop.Database.Interfaces;
using Shop.Database.Repositories;

namespace Shop.Application.Services
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureScopedSerivces(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductService, ProductService>();
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
