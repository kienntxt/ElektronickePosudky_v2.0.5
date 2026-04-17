using Serilog.Context;

namespace ElektronickePosudky.API.Middleware
{
    public sealed class CorrelationIdMiddleware : IMiddleware
    {
        public const string HeaderName = "X-Correlation-Id";

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (!context.Request.Headers.ContainsKey(HeaderName))
            {
                context.Request.Headers[HeaderName] = Guid.NewGuid().ToString();
            }

            var correlationId = context.Request.Headers[HeaderName].ToString();

            using (LogContext.PushProperty("CorrelationId", correlationId))
            {
                context.Response.OnStarting(() =>
                {
                    if (!context.Response.Headers.ContainsKey(HeaderName))
                    {
                        context.Response.Headers[HeaderName] = correlationId;
                    }
                    return Task.CompletedTask;
                });

                await next(context);
            }
        }
    }
}
