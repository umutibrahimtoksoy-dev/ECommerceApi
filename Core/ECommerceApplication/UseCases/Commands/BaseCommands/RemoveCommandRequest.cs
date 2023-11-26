using MediatR;

namespace ECommerceApplication.UseCases.Commands.BaseCommands
{
    public class RemoveCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }

        public RemoveCommandRequest(int id)
        {
            Id = id;
        }

        public RemoveCommandRequest()
        {

        }
    }
}
