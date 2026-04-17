using System.Text.Json;
using ElektronickePosudky.API.Resources;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace ElektronickePosudky.API.Middleware
{
    public sealed class ExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        private readonly IWebHostEnvironment _environment;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public ExceptionHandlingMiddleware(
            ILogger<ExceptionHandlingMiddleware> logger,
            IWebHostEnvironment environment,
            IStringLocalizer<SharedResource> localizer
        )
        {
            _logger = logger;
            _environment = environment;
            _localizer = localizer;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            _logger.LogError(exception, "Unhandled exception caught by global middleware");

            context.Response.ContentType = "application/problem+json";
            var problem = new ProblemDetails { Instance = context.Request.Path };

            switch (exception)
            {
                case ValidationException validationException:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    problem.Type = "https://api.elp.cz/errors/validation";
                    problem.Title = _localizer["ValidationErrorTitle"];
                    problem.Status = StatusCodes.Status400BadRequest;
                    problem.Detail = _localizer["ValidationErrorDetail"];
                    problem.Extensions["errors"] = validationException.Errors.Select(err => new
                    {
                        field = err.PropertyName,
                        message = err.ErrorMessage,
                    });
                    break;
                case DbUpdateConcurrencyException:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    problem.Type = "https://api.elp.cz/errors/validation";
                    problem.Title = _localizer["ConcurrencyErrorTitle"];
                    problem.Status = StatusCodes.Status400BadRequest;
                    problem.Detail = _localizer["ConcurrencyErrorDetail"];
                    break;
                case KeyNotFoundException:
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                    problem.Type = "https://api.elp.cz/errors/not-found";
                    problem.Title = _localizer["NotFoundErrorTitle"];
                    problem.Status = StatusCodes.Status404NotFound;
                    problem.Detail = exception.Message;
                    break;
                case InvalidOperationException:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    problem.Type = "https://api.elp.cz/errors/validation";
                    problem.Title = _localizer["InvalidOperationErrorTitle"];
                    problem.Status = StatusCodes.Status400BadRequest;
                    problem.Detail = exception.Message;
                    break;
                default:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    problem.Type = "https://api.elp.cz/errors/internal";
                    problem.Title = _localizer["InternalServerErrorTitle"];
                    problem.Status = StatusCodes.Status500InternalServerError;
                    problem.Detail = _environment.IsDevelopment()
                        ? exception.Message
                        : _localizer["InternalServerErrorDetail"];
                    break;
            }

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            await JsonSerializer.SerializeAsync(context.Response.Body, problem, options);
        }
    }
}
