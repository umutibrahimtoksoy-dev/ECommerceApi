using MediatR;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.UpdateProductCommand
{
    public class UpdateProductCommandRequest : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
