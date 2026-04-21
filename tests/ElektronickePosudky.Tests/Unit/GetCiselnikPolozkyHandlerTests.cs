using System.Linq;
using ElektronickePosudky.Application.Handlers;
using ElektronickePosudky.Application.Queries;
using ElektronickePosudky.Infrastructure.Persistence;
using FluentAssertions;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class GetCiselnikPolozkyHandlerTests
    {
        [Fact]
        public async Task Handle_ReturnsItemsForExistingCiselnikKod()
        {
            await using var context = TestHelpers.CreateContext();
            var handler = new GetCiselnikPolozkyHandler(context, TestHelpers.CreateMapper());

            var result = await handler.Handle(
                new GetCiselnikPolozkyQuery { Kod = "stav-posudku" },
                System.Threading.CancellationToken.None
            );

            result.Should().NotBeNull();
            result.Should().HaveCountGreaterThanOrEqualTo(1);
            result
                .Select(x => x.Kod)
                .Should()
                .Contain(["stav_posudku_1", "stav_posudku_2", "stav_posudku_3"]);
        }
    }
}
