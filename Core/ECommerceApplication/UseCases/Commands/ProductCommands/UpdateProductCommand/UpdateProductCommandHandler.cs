using AutoMapper;
using ECommerceApplication.Repositories.IProductRepository;
using ECommerceDomain.Entities;
using MediatR;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.UpdateProductCommand
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, int>
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductWriteRepository productWriteRepository,
            IProductReadRepository productReadRepository,
            IMapper mapper)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }


        public async Task<int> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = await _productReadRepository.GetByIdAsync(request.Id);

            Product updatedProduct = _mapper.Map<Product>(request);

            _productWriteRepository.Update(updatedProduct);

            await _productWriteRepository.SaveChangesAsync();

            return product.Id;
        }
    }
}