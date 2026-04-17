using ElektronickePosudky.Application.Queries;
using FluentValidation;

namespace ElektronickePosudky.Application.Validators
{
    public sealed class SearchPosudkyValidator : AbstractValidator<SearchPosudkyQuery>
    {
        public SearchPosudkyValidator()
        {
            RuleFor(x => x.SearchRequest.Page)
                .GreaterThan(0)
                .When(x => x.SearchRequest.Page.HasValue);
            RuleFor(x => x.SearchRequest.Size)
                .GreaterThan(0)
                .When(x => x.SearchRequest.Size.HasValue);
            RuleFor(x => x.SearchRequest.Order)
                .Must(value =>
                    value == null
                    || value.Equals("asc", System.StringComparison.OrdinalIgnoreCase)
                    || value.Equals("desc", System.StringComparison.OrdinalIgnoreCase)
                )
                .WithMessage("Order must be asc or desc.");
        }
    }
}
