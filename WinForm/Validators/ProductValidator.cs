using Entity;
using FluentValidation;
using System.Collections.Generic;

namespace UI.Validators
{
    class ProductValidator : AbstractValidator<ProductData>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Model)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Product model is required");
            RuleFor(p => p.Descriptions)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(IsValidDescription)
                .WithMessage("Product name and meta tag title are required");
        }

        private bool IsValidDescription(IDictionary<int, Description> descriptions)
        {
            foreach (KeyValuePair<int, Description> description in descriptions)
                if (string.IsNullOrWhiteSpace(description.Value.Name) || string.IsNullOrWhiteSpace(description.Value.MetaTitle))
                    return false;
            return true;
        }
    }
}
