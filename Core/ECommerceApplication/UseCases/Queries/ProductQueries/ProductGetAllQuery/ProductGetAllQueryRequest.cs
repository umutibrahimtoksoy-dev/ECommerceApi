using MediatR;

namespace ECommerceApplication.UseCases.Queries.ProductQueries.ProductGetAllQuery
{
    public class ProductGetAllQueryRequest : IRequest<List<ProductGetAllQueryResponse>>
    {

    }
}
