# Elektronicke Posudky

Elektronicke Posudky is a .NET 8.0-based web API application designed for managing electronic medical certificate for the driver fitness assessment. The application follows Clean Architecture principles and implements CQRS (Command Query Responsibility Segregation) pattern using MediatR.

## Features

- **RESTful API**: Built with ASP.NET Core for handling assessment-related operations
- **Multi-language Support**: Localization support for Czech and other languages
- **Validation**: Comprehensive input validation using FluentValidation
- **Logging**: Structured logging with Serilog
- **Database**: SQL Server with Entity Framework Core
- **Containerization**: Docker support for easy deployment
- **CQRS Pattern**: Separated commands and queries for better maintainability
- **Auto-mapping**: Object mapping with AutoMapper
- **API Documentation**: Swagger/OpenAPI integration

## Architecture

The solution is organized into multiple layers following Clean Architecture:

- **API Layer** (`ElektronickePosudky.API`): ASP.NET Core controllers, middleware, and configuration
- **Application Layer** (`ElektronickePosudky.Application`): Business logic, commands, queries, DTOs, and validators
- **Domain Layer** (`ElektronickePosudky.Domain`): Domain entities and business rules
- **Infrastructure Layer** (`ElektronickePosudky.Infrastructure`): Data access, migrations, and external services

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started) and Docker Compose
- SQL Server (local or Docker container)

## Installation

1. Clone the repository:

   ```bash
   git clone <repository-url>
   cd ElektronickePosudky
   ```

2. Create environment file:

   ```bash
   cp .env.example .env
   ```

   Edit `.env` with your configuration values.

## Running the Application

### Using Docker (Recommended)

1. Ensure Docker and Docker Compose are installed.

2. Start the services:

   ```bash
   docker-compose up -d
   ```

   This will start:
   - SQL Server database
   - Database initializer (runs init.sql)
   - Migration service (applies EF Core migrations)
   - API application

3. The API will be available at `http://localhost:5000` (or configured port).

### Running Locally

1. Ensure SQL Server is running and accessible.

2. Update `appsettings.json` or environment variables with the correct connection string.

3. Run database migrations:

   ```bash
   cd src/ElektronickePosudky.API
   dotnet ef database update
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

5. The API will be available at `https://localhost:5001` (or configured port).

## Testing

Run the unit tests:

```bash
dotnet test tests/ElektronickePosudky.Tests/ElektronickePosudky.Tests.csproj
```

## API Documentation

When running, visit `http://localhost:5000/swagger` (or configured URL) to access the Swagger UI for API documentation and testing.

## Configuration

Key configuration options in `appsettings.json`:

- `ConnectionStrings.DefaultConnection`: Database connection string
- `Serilog`: Logging configuration
- `Localization`: Supported cultures

Environment variables (via `.env` for Docker):

- `DB_SA_PASSWORD`: SQL Server SA password
- `DB_NAME`: Database name
- `DB_USER`: Application database user
- `DB_PASSWORD`: Application database password
- `ConnectionStrings__DefaultConnection`: Full connection string for migrations

## Development

### Project Structure

```text
src/
├── ElektronickePosudky.API/          # Web API project
├── ElektronickePosudky.Application/   # Application logic
├── ElektronickePosudky.Domain/        # Domain entities
└── ElektronickePosudky.Infrastructure/ # Data access & infrastructure

tests/
└── ElektronickePosudky.Tests/         # Unit tests

init/
└── init.sql                          # Database initialization script
```

### Adding New Features

1. Define domain entities in `Domain`
2. Create commands/queries in `Application`
3. Implement handlers in `Application`
4. Add controllers in `API`
5. Write tests in `Tests`

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Add tests
5. Submit a pull request
