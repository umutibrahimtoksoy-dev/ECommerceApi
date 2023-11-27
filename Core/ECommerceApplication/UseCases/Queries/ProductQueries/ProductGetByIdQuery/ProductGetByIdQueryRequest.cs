using ECommerceApplication.UseCases.Queries.BaseQueries;

namespace ECommerceApplication.UseCases.Queries.ProductQueries.ProductGetByIdQuery
{
    public class ProductGetByIdQueryRequest : GetByIdQueryRequest<ProductGetByIdQueryResponse>
    {
        public ProductGetByIdQueryRequest(int id) : base(id)
        {
        }
    }
}
