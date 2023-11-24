using AutoMapper;
using ECommerceApplication.Repositories.IProductRepository;
using ECommerceDomain.Entities;
using MediatR;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.AddProductCommand
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommandRequest, int>
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IMapper _mapper;

        public AddProductCommandHandler(IProductWriteRepository productWriteRepository,
            IMapper mapper)
        {
            _productWriteRepository = productWriteRepository;
            _mapper = mapper;
        }


        public async Task<int> Handle(AddProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request);

            await _productWriteRepository.AddAsync(product);

            await _productWriteRepository.SaveChangesAsync();

            return product.Id;
        }
    }
}