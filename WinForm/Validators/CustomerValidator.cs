using Entity;
using FluentValidation;
using System.Text.RegularExpressions;

namespace UI.Validators
{
    internal class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerGroupID)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(cg => cg > 0).WithMessage("Select customer group");
            RuleFor(c => c.Firstname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Firstname is required")
                .Must(IsValidName).WithMessage("Firstname is required");
            RuleFor(c => c.Lastname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lastname is required")
                .Must(IsValidName).WithMessage("Lastname is required");
            RuleFor(c => c.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format");
            RuleFor(c => c.Telephone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Telephone is required")
                .Must(IsValidTelephone).WithMessage("Telephone is required");
            RuleFor(c => c.Address).SetValidator(new AddressValidator());
        }

        private bool IsValidTelephone(string number) => Regex.Match(number, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}").Success;

        private bool IsValidName(string name) => Regex.IsMatch(name, @"^[\w+\s]*$", RegexOptions.IgnoreCase);
    }
}
