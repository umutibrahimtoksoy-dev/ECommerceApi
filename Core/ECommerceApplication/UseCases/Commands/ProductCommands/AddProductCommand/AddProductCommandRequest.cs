using MediatR;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.AddProductCommand
{
    public class AddProductCommandRequest : IRequest<int>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
