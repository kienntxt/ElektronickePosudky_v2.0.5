using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.Handlers;
using ElektronickePosudky.Infrastructure.Persistence;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class CheckOpravneniHandlerTests
    {
        [Fact]
        public async Task Handle_ReturnsTrueWhenIcoMatchesProvider()
        {
            await using var context = TestHelpers.CreateContext();
            var doctor = await context
                .ZdravotnickyPracovnici.Include(x => x.Poskytovatel)
                .FirstAsync();

            var handler = new CheckOpravneniHandler(context, TestHelpers.CreateMapper());
            var result = await handler.Handle(
                new CheckOpravneniCommand
                {
                    Request = new Application.DTO.PosudekRoOpravneniRequestDto
                    {
                        Ico = doctor.Poskytovatel!.Ico,
                        KrzpId = doctor.KrzpId.ToString(),
                    },
                },
                System.Threading.CancellationToken.None
            );

            result.Opravneni.Should().BeTrue();
        }

        [Fact]
        public async Task Handle_ReturnsFalseWhenIcoDoesNotMatchProvider()
        {
            await using var context = TestHelpers.CreateContext();
            var doctor = await context.ZdravotnickyPracovnici.FirstAsync();

            var handler = new CheckOpravneniHandler(context, TestHelpers.CreateMapper());
            var result = await handler.Handle(
                new CheckOpravneniCommand
                {
                    Request = new Application.DTO.PosudekRoOpravneniRequestDto
                    {
                        Ico = "00000000",
                        KrzpId = doctor.KrzpId.ToString(),
                    },
                },
                System.Threading.CancellationToken.None
            );

            result.Opravneni.Should().BeFalse();
        }
    }
}
