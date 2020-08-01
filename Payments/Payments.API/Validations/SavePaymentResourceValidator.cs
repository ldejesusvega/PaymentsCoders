using FluentValidation;
using Payment.Domain;

namespace Payments.API.Validations
{
    public class SavePaymentResourceValidator : AbstractValidator<SavePaymentResource>
    {
        public SavePaymentResourceValidator()
        {
            RuleFor(x => x.Concept)
                .NotEmpty()
                .MaximumLength(250)
                .WithMessage("Excedio la longitud maxima del campo");

            RuleFor(x => x.Date)
                .NotEmpty()
                .WithMessage("Fecha es requerida");

            RuleFor(x => x.Amount)
                .NotEmpty()
                .WithMessage("Amount es requerido")
                .ScalePrecision(4, 10)
                .WithMessage("Price debe ser mayor a 0 (cero)");
        }
    }
}