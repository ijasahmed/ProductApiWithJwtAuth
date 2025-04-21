using ApiSampleCrud.Models;
using AutoMapper;
using SampleApiReact.DTOS;

namespace SampleApiReact.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}
