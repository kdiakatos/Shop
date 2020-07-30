using AutoMapper;
using Shop.Application.Models;
using Shop.Domain.Models;

namespace Shop.UI.Utilities
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
        }

    }
}
