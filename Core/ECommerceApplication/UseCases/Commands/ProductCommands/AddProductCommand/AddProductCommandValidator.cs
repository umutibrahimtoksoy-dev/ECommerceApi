using FluentValidation;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.AddProductCommand
{
    public class AddProductCommandValidator : AbstractValidator<AddProductCommandRequest>
    {
        public AddProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.Quantity)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Price)
                .GreaterThan(0);

            RuleFor(x => x.CurrencyCode)
                .NotEmpty();
        }
    }
}
