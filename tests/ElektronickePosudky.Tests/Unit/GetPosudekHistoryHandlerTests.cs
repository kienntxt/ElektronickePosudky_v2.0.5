using System.Linq;
using ElektronickePosudky.Application.Handlers;
using ElektronickePosudky.Application.Queries;
using ElektronickePosudky.Infrastructure.Persistence;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class GetPosudekHistoryHandlerTests
    {
        [Fact]
        public async Task Handle_ReturnsHistoryForExistingCertificate()
        {
            await using var context = TestHelpers.CreateContext();
            var certificateId = await context.PosudekRos.Select(x => x.Id).FirstAsync();
            var handler = new GetPosudekHistoryHandler(context, TestHelpers.CreateMapper());

            var result = await handler.Handle(
                new GetPosudekHistoryQuery { Id = certificateId },
                System.Threading.CancellationToken.None
            );

            result.Should().NotBeNull();
            result.Should().NotBeEmpty();
            result.Should().BeInDescendingOrder(x => x.DatumOperace);
            result.All(x => x.TypOperace != null).Should().BeTrue();
        }
    }
}
