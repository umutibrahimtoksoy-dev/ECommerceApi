using AutoMapper;
using ECommerceApplication.Repositories.IProductRepository;
using ECommerceDomain.Entities;
using MediatR;

namespace ECommerceApplication.UseCases.Queries.ProductQueries.ProductGetAllQuery
{
    public class ProductGetAllQueryHandler : IRequestHandler<ProductGetAllQueryRequest, List<ProductGetAllQueryResponse>>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public ProductGetAllQueryHandler(IProductReadRepository productReadRepository,
            IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductGetAllQueryResponse>> Handle(ProductGetAllQueryRequest request, CancellationToken cancellationToken)
        {
            List<Product> productList = await _productReadRepository.GetListAsync();

            List<ProductGetAllQueryResponse> productGetAllQueryResponseList = _mapper.Map<List<ProductGetAllQueryResponse>>(productList);

            return productGetAllQueryResponseList;
        }
    }
}
