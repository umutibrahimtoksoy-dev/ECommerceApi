using ECommerceApplication.UseCases.Commands.BaseCommands;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.RemoveProductCommand
{
    public class RemoveProductCommandRequest : RemoveCommandRequest
    {
        public RemoveProductCommandRequest(int id) : base(id)
        {

        }
    }
}
