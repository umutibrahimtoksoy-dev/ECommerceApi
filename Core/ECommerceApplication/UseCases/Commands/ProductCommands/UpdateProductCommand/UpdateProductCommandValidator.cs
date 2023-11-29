using FluentValidation;

namespace ECommerceApplication.UseCases.Commands.ProductCommands.UpdateProductCommand
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommandRequest>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);

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
