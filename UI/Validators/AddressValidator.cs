using Entity;
using FluentValidation;

namespace UI.Validators
{
    internal class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            // Firstname
            RuleFor(a => a.Firstname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.City) ||
                           !string.IsNullOrWhiteSpace(a.Lastname))
                .WithMessage("Firtname in address is required");
            // Lastname
            RuleFor(a => a.Lastname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.City) ||
                           !string.IsNullOrWhiteSpace(a.Firstname))
                .WithMessage("Lastname in address is required");
            // Address #1
            RuleFor(a => a.Address1)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .When(a => !string.IsNullOrWhiteSpace(a.Firstname) ||
                           !string.IsNullOrWhiteSpace(a.Lastname) ||
                           !string.IsNullOrWhiteSpace(a.City))
                .WithMessage("Address #1 is required");
            // City
            RuleFor(a => a.City)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.Lastname) ||
                           !string.IsNullOrWhiteSpace(a.Firstname))
                .WithMessage("City is required");
            // Country
            RuleFor(a => a.CountryID)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(c => c != 0)
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.Firstname) ||
                           !string.IsNullOrWhiteSpace(a.Lastname) ||
                           !string.IsNullOrWhiteSpace(a.City) ||
                           a.ZoneID != 0)
                .WithMessage("Country is required");
            // Zone
            RuleFor(a => a.ZoneID)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(z => z != 0)
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.Lastname) ||
                           !string.IsNullOrWhiteSpace(a.Firstname) ||
                           !string.IsNullOrWhiteSpace(a.City))
                .WithMessage("Region is required");
        }
    }
}
