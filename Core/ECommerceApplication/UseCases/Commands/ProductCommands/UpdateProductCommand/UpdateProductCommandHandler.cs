using AutoMapper;
using ECommerceApplication.Repositories.IProductRepository;
using ECommerceDomain.Entities;
using MediatR;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.UpdateProductCommand
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, int>
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductWriteRepository productWriteRepository,
            IMapper mapper)
        {
            _productWriteRepository = productWriteRepository;
            _mapper = mapper;
        }


        public async Task<int> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request);

            _productWriteRepository.Update(product);

            await _productWriteRepository.SaveChangesAsync();

            return product.Id;
        }
    }
}