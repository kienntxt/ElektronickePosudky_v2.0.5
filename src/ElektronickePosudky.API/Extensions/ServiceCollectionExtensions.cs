using System.Data;
using System.Globalization;
using ElektronickePosudky.API.Middleware;
using ElektronickePosudky.Application.Behaviors;
using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Application.Localization;
using ElektronickePosudky.Application.Mapping;
using ElektronickePosudky.Application.Validators;
using ElektronickePosudky.Infrastructure.Persistence;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace ElektronickePosudky.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApiServices(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddScoped<CorrelationIdMiddleware>();
            services.AddScoped<ExceptionHandlingMiddleware>();
            services.AddScoped<AcceptLanguageMiddleware>();

            services.AddDbContext<IElektronickePosudkyContext, ElektronickePosudkyContext>(
                options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection")
                            ?? "Server=localhost,1433;Database=ElektronickePosudky;User=app_user;Password=Passw0rd!;TrustServerPosudekRo=True;",
                        sqlOptions =>
                            sqlOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                    )
            );

            services.AddControllers();

            services.AddHttpContextAccessor();

            services.AddLocalization();

            // Register database-based localization
            // services.AddSingleton<IStringLocalizerFactory, DatabaseStringLocalizerFactory>();
            services.AddTransient(typeof(IStringLocalizer<>), typeof(StringLocalizer<>));

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // Register MappingProfile with its dependency
            services.AddScoped<MappingProfile>();
            services.AddAutoMapper(options =>
            {
                options.AddProfile(typeof(MappingProfile));
            });

            // Register validators from Application assembly for MediatR pipeline validation
            var applicatinAssembly = typeof(IValidatorMarker).Assembly;
            var validatorType = typeof(IValidator<>);

            foreach (var type in applicatinAssembly.GetTypes())
            {
                if (type.IsAbstract || type.IsInterface)
                    continue;

                var interfaces = type.GetInterfaces();
                foreach (var iface in interfaces)
                {
                    if (iface.IsGenericType && iface.GetGenericTypeDefinition() == validatorType)
                    {
                        services.AddTransient(iface, type);
                    }
                }
            }

            // Register MediatR and validation pipeline behavior
            var applicationAssembly = typeof(IValidatorMarker).Assembly;
            services.AddMediatR(typeof(Program).Assembly, applicationAssembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(
            this IApplicationBuilder app,
            IHostEnvironment environment
        )
        {
            app.UseMiddleware<CorrelationIdMiddleware>();
            app.UseMiddleware<AcceptLanguageMiddleware>();

            var supportedCultures = DefaultLocalizationOptions
                .SupportedCultures.Select(c => new CultureInfo(c))
                .ToArray();
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(
                    DefaultLocalizationOptions.DefaultCultureName
                ),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
            };

            app.UseRequestLocalization(localizationOptions);
            app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.UseRouting();
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
            return app;
        }
    }
}
