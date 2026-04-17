using AutoMapper;
using ElektronickePosudky.Application.Mapping;
using ElektronickePosudky.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ElektronickePosudky.Tests.Unit
{
    internal static class TestHelpers
    {
        public static IMapper CreateMapper()
        {
            var services = new ServiceCollection();
            services.AddAutoMapper(x => x.AddMaps(typeof(MappingProfile).Assembly));
            services.AddLogging();
            var provider = services.BuildServiceProvider();
            return provider.GetRequiredService<IMapper>();
        }

        public static ElektronickePosudkyContext CreateContext(string? databaseName = null)
        {
            var options = new DbContextOptionsBuilder<ElektronickePosudkyContext>()
                .UseInMemoryDatabase(databaseName ?? System.Guid.NewGuid().ToString())
                .Options;

            var context = new ElektronickePosudkyContext(options);
            context.Database.EnsureCreated();
            return context;
        }
    }
}
