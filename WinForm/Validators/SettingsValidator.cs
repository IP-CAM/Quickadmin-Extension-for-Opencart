using FluentValidation;
using UI.Models;

namespace UI.Validators
{
    internal class SettingsValidator : AbstractValidator<ISettings>
    {
        public SettingsValidator()
        {
            RuleFor(p => p.Email)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Email has not been typed");
            RuleFor(p => p.EmailPwd)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Email password has not been typed");
            RuleFor(p => p.Host)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Email service host has not been typed");
            RuleFor(p => p.Port)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Mail port has not been typed");
        }
    }
}
