using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Queries;
using ElektronickePosudky.Application.Validators;
using FluentAssertions;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class SearchPosudkyValidatorTests
    {
        [Fact]
        public void Validate_ReturnsValidResultWhenSearchRequestIsCorrect()
        {
            var validator = new SearchPosudkyValidator();
            var query = new SearchPosudkyQuery
            {
                SearchRequest = new PosudkyRoSearchRequest
                {
                    Page = 1,
                    Size = 10,
                    Order = "desc",
                },
            };

            var result = validator.Validate(query);

            result.IsValid.Should().BeTrue();
        }

        [Fact]
        public void Validate_ReturnsInvalidResultWhenPagingOrOrderIsInvalid()
        {
            var validator = new SearchPosudkyValidator();
            var query = new SearchPosudkyQuery
            {
                SearchRequest = new PosudkyRoSearchRequest
                {
                    Page = 0,
                    Size = 0,
                    Order = "invalid",
                },
            };

            var result = validator.Validate(query);

            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(x => x.PropertyName == "SearchRequest.Page");
            result.Errors.Should().Contain(x => x.PropertyName == "SearchRequest.Size");
            result.Errors.Should().Contain(x => x.PropertyName == "SearchRequest.Order");
        }
    }
}
