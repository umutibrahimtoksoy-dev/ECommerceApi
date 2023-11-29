using ECommerceApplication.UseCases.Commands.ProductCommands.RemoveProductCommand;
using FluentValidation;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.UpdateProductCommand
{
    public class RemoveProductCommandValidator : AbstractValidator<RemoveProductCommandRequest>
    {
        public RemoveProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
