using AutoMapper;
using ECommerceApplication.UseCases.Commands.ProductCommands.AddProductCommand;
using ECommerceApplication.UseCases.Commands.ProductCommands.UpdateProductCommand;
using ECommerceApplication.UseCases.Queries.ProductQueries.ProductGetAllQuery;
using ECommerceApplication.UseCases.Queries.ProductQueries.ProductGetByIdQuery;
using ECommerceDomain.Entities;

namespace ECommerceApplication.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<AddProductCommandRequest, Product>();
            CreateMap<UpdateProductCommandRequest, Product>();
            CreateMap<Product, ProductGetByIdQueryResponse>();
            CreateMap<Product, ProductGetAllQueryResponse>();
        }
    }
}
