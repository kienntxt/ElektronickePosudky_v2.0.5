using AutoMapper;
using ElektronickePosudky.Application.Handlers;
using ElektronickePosudky.Application.Mapping;
using ElektronickePosudky.Application.Queries;
using ElektronickePosudky.Infrastructure.Persistence;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class GetCiselnikyHandlerTests
    {
        private static IMapper CreateMapper()
        {
            var services = new ServiceCollection();
            services.AddAutoMapper(x => x.AddMaps(typeof(MappingProfile).Assembly));
            services.AddLogging();
            var provider = services.BuildServiceProvider();
            return provider.GetRequiredService<IMapper>();
        }

        [Fact]
        public async Task GetCiselnikyHandler_ReturnsSeededCiselnik()
        {
            var options = new DbContextOptionsBuilder<ElektronickePosudkyContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            await using var context = new ElektronickePosudkyContext(options);
            await context.Database.EnsureCreatedAsync();

            var handler = new GetCiselnikyHandler(context, CreateMapper());
            var result = await handler.Handle(new GetCiselnikyQuery(), CancellationToken.None);

            result.Should().NotBeNull();
            result.Should().NotBeEmpty();
            result.Should().Contain(x => x.Kod == "stav-posudku");
        }
    }
}
