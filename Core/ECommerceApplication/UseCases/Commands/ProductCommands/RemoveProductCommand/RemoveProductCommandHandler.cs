using ECommerceApplication.Repositories.IProductRepository;
using MediatR;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.RemoveProductCommand
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommandRequest, bool>
    {
        private readonly IProductWriteRepository _productWriteRepository;

        public RemoveProductCommandHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }


        public async Task<bool> Handle(RemoveProductCommandRequest request, CancellationToken cancellationToken)
        {
            bool result = await _productWriteRepository.RemoveAsync(request.Id);

            await _productWriteRepository.SaveChangesAsync();

            return result;
        }
    }
}