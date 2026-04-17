using ElektronickePosudky.API.Extensions;
using ElektronickePosudky.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddApiServices(builder.Configuration);

var app = builder.Build();

// // Apply database migrations and seed data on startup
// try
// {
//     Log.Information("Starting database migration...");
//     using (var scope = app.Services.CreateScope())
//     {
//         var dbContext = scope.ServiceProvider.GetRequiredService<ElektronickePosudkyContext>();

//         // Wait for database to be available (with retry logic)
//         int maxRetries = 30;
//         int retryCount = 0;
//         while (retryCount < maxRetries)
//         {
//             try
//             {
//                 if (await dbContext.Database.CanConnectAsync())
//                 {
//                     Log.Information("Database connection successful");
//                     break;
//                 }
//             }
//             catch (Exception ex)
//             {
//                 retryCount++;
//                 if (retryCount >= maxRetries)
//                 {
//                     Log.Fatal(
//                         ex,
//                         "Failed to connect to database after {maxRetries} attempts",
//                         maxRetries
//                     );
//                     throw;
//                 }
//                 Log.Warning(
//                     "Database connection attempt {retryCount}/{maxRetries} failed. Retrying in 2 seconds...",
//                     retryCount,
//                     maxRetries
//                 );
//                 await Task.Delay(2000);
//             }
//         }

//         // Apply migrations
//         Log.Information("Applying database migrations...");
//         await dbContext.Database.MigrateAsync();
//         Log.Information("Database migrations completed successfully");
//     }
// }
// catch (Exception ex)
// {
//     Log.Fatal(ex, "An error occurred during database migration");
//     throw;
// }

app.UseApiConfiguration(app.Environment);

app.Run();
