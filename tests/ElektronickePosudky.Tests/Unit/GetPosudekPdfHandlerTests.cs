using ElektronickePosudky.Application.Handlers;
using ElektronickePosudky.Application.Queries;
using ElektronickePosudky.Infrastructure.Persistence;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class GetPosudekPdfHandlerTests
    {
        [Fact]
        public async Task Handle_ReturnsPlaceholderPdfContent()
        {
            await using var context = TestHelpers.CreateContext();
            var certificateId = await context.PosudekRos.Select(x => x.Id).FirstAsync();
            var handler = new GetPosudekPdfHandler(context);

            var result = await handler.Handle(
                new GetPosudekPdfQuery { Id = certificateId },
                System.Threading.CancellationToken.None
            );

            result.Should().NotBeNull();
            var content = System.Text.Encoding.UTF8.GetString(result);
            content.Should().Contain($"PDF placeholder for certificate {certificateId}");
        }

        [Fact]
        public async Task Handle_ThrowsKeyNotFoundExceptionWhenCertificateMissing()
        {
            await using var context = TestHelpers.CreateContext();
            var handler = new GetPosudekPdfHandler(context);

            await handler
                .Invoking(h =>
                    h.Handle(
                        new GetPosudekPdfQuery { Id = System.Guid.NewGuid() },
                        System.Threading.CancellationToken.None
                    )
                )
                .Should()
                .ThrowAsync<KeyNotFoundException>();
        }
    }
}
