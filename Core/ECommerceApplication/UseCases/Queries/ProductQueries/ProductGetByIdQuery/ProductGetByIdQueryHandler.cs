using AutoMapper;
using ECommerceApplication.Repositories.IProductRepository;
using ECommerceDomain.Entities;
using MediatR;

namespace ECommerceApplication.UseCases.Queries.ProductQueries.ProductGetByIdQuery
{
    public class ProductGetByIdQueryHandler : IRequestHandler<ProductGetByIdQueryRequest, ProductGetByIdQueryResponse>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public ProductGetByIdQueryHandler(IProductReadRepository productReadRepository,
            IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<ProductGetByIdQueryResponse> Handle(ProductGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Product product = await _productReadRepository.GetByIdAsync(request.Id);

            ProductGetByIdQueryResponse productGetByIdResponse = _mapper.Map<ProductGetByIdQueryResponse>(product);

            return productGetByIdResponse;
        }
    }
}
