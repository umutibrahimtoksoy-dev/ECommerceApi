using AutoMapper;
using ECommerceApplication.UseCases.Commands.ProductCommands.AddProductCommand;
using ECommerceDomain.Entities;

namespace ECommerceApplication.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<AddProductCommandRequest, Product>();
        }
    }
}
