using Entity;
using FluentValidation;

namespace UI.Validators
{
    internal class OrderValidator : AbstractValidator<OrderData>
    {
        public OrderValidator()
        {
            // Customer
            RuleFor(o => o.Customer)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .SetValidator(new CustomerValidator());
            // Currency
            RuleFor(o => o.Currency.ID)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Select currency");
            // Products
            RuleFor(o => o.Products.Count)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("Add products to the cart");
            // Payment Method
            RuleFor(o => o.PaymentMethod.Code)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Select the payment method");
            // Payment address
            RuleFor(o => o.PaymentAddress)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .SetValidator(new AddressValidator())
                .WithMessage("Please, check that the required payment address fields are typed");
            // Shipping Method
            RuleFor(o => o.ShippingMethod.Code)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("Selecct shipping method");
            // Shipping address
            RuleFor(o => o.ShippingAddress)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .SetValidator(new AddressValidator())
                .WithMessage("Please, check that the required shipping address fields are typed");
            // Order Status
            RuleFor(o => o.OrderStatus)
                .NotEmpty().WithMessage("Order status is not selected");
        }

        private bool ValidateAddress(Address addr)
            => string.IsNullOrWhiteSpace(addr.Firstname) ||
               string.IsNullOrWhiteSpace(addr.Lastname) ||
               string.IsNullOrWhiteSpace(addr.Address1) ||
               string.IsNullOrWhiteSpace(addr.City) ||
               addr.CountryID == 0 || addr.ZoneID == 0;
    }
}
