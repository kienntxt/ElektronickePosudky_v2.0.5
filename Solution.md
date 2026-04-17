# Elektronicke Posudky - Solution Architecture

## Overview

Elektronicke Posudky is a .NET 8.0-based enterprise application designed for managing electronic medical certificate for the driver fitness assessment. The solution follows Clean Architecture principles with CQRS (Command Query Responsibility Segregation) pattern, ensuring maintainability, testability, and scalability.

## Solution Structure

The solution is organized into multiple projects, each with a specific responsibility following the principles of Clean Architecture and SOLID design.

### Core Technologies

- **Framework**: .NET 8.0
- **Architecture**: Clean Architecture with CQRS
- **Database**: SQL Server 2022
- **ORM**: Entity Framework Core 8.0
- **Containerization**: Docker & Docker Compose
- **Testing**: xUnit, FluentAssertions
- **Documentation**: Swagger/OpenAPI

## Project Structure

### 1. ElektronickePosudky.API

**Purpose**: The presentation layer and entry point of the application. This project contains the ASP.NET Core Web API controllers, middleware, configuration, and hosting setup.

**Key Responsibilities**:

- HTTP request handling and routing
- API endpoint definitions
- Authentication and authorization
- Request/response serialization
- Exception handling and logging
- Swagger documentation

**Technologies Used**:

- ASP.NET Core 8.0 Web API
- AutoMapper (object mapping)
- FluentValidation (request validation)
- MediatR (CQRS implementation)
- Serilog (structured logging)
- Swashbuckle (Swagger/OpenAPI)
- Microsoft.EntityFrameworkCore.SqlServer (database access)
- Microsoft.Extensions.Localization (localization support)

**Key Components**:

- Controllers (CiselnikyController, PosudkyController)
- Middleware (ExceptionHandlingMiddleware, CorrelationIdMiddleware, AcceptLanguageMiddleware)
- Extensions (ServiceCollectionExtensions)
- Resources (SharedResource for localization)

**API Endpoints**:

The API exposes the following endpoints organized by controller:

#### CiselnikyController (`/api/v2/ciselniky`)

- `GET /api/v2/ciselniky` - Retrieves all codebooks (ciselniky)
- `GET /api/v2/ciselniky/{kod}/polozky` - Retrieves items for a specific codebook

#### PosudkyController (`/api/v2/posudky/ridicskeOpravneni`)

- `POST /api/v2/posudky/ridicskeOpravneni` - Creates a new assessment (posudek)
- `POST /api/v2/posudky/ridicskeOpravneni/vyhledat` - Searches for assessments
- `GET /api/v2/posudky/ridicskeOpravneni/{id}/pdf` - Downloads assessment PDF
- `GET /api/v2/posudky/ridicskeOpravneni/{id}/historie` - Retrieves assessment history
- `PATCH /api/v2/posudky/ridicskeOpravneni/{id}/zneplatnit` - Invalidates an assessment
- `POST /api/v2/posudky/ridicskeOpravneni/zalozeni/opravneni` - Checks permissions for creating assessments

All endpoints support:

- `Accept-Language` header for localization
- `X-Correlation-Id` header for request tracing
- `If-Match` header for concurrency control (where applicable)

### 2. ElektronickePosudky.Application

**Purpose**: Contains the application business logic, use cases, and orchestration. This layer implements the CQRS pattern with commands and queries.

**Key Responsibilities**:

- Business logic implementation
- Command and query handling
- Input validation
- Data transformation (DTOs)
- Cross-cutting concerns (validation behavior)
- Application services

**Technologies Used**:

- MediatR (CQRS mediator)
- AutoMapper (object mapping)
- FluentValidation (business rule validation)
- Microsoft.EntityFrameworkCore (database abstraction)
- Microsoft.Extensions.Localization (localization)
- Microsoft.AspNetCore.Http (HTTP context access)

**Key Components**:

- Commands (CreatePosudekCommand, CheckOpravneniCommand, etc.)
- Queries (various query classes)
- Handlers (command and query handlers)
- DTOs (Data Transfer Objects for API communication)
- Validators (FluentValidation validators)
- Behaviors (ValidationBehavior for pipeline behavior)
- Mapping profiles (AutoMapper configurations)

### 3. ElektronickePosudky.Domain

**Purpose**: The core business domain layer containing domain entities, value objects, and business rules. This layer is independent of any external frameworks or technologies.

**Key Responsibilities**:

- Domain entity definitions
- Business rule encapsulation
- Domain logic implementation
- Value object definitions

**Technologies Used**:

- .NET 8.0 (pure domain logic, no external dependencies)

**Key Components**:

- Entities (domain objects representing business concepts)
- Value Objects (immutable objects representing values)
- Domain Services (business logic that doesn't belong to entities)

### 4. ElektronickePosudky.Infrastructure

**Purpose**: The infrastructure layer handling external concerns such as data persistence, external services, and framework-specific implementations.

**Key Responsibilities**:

- Database access and persistence
- Entity Framework configuration
- Database migrations
- Repository implementations
- External service integrations

**Technologies Used**:

- Entity Framework Core 8.0
- Microsoft.EntityFrameworkCore.SqlServer (SQL Server provider)
- Microsoft.EntityFrameworkCore.Design (migration tools)

**Key Components**:

- DbContext (Entity Framework database context)
- Migrations (database schema evolution)
- Repositories (data access patterns)
- Persistence configurations

### 5. ElektronickePosudky.Tests

**Purpose**: Unit and integration tests ensuring code quality and preventing regressions.

**Key Responsibilities**:

- Unit testing of business logic
- Integration testing of components
- Test data setup and mocking
- Code coverage analysis

**Technologies Used**:

- xUnit (testing framework)
- FluentAssertions (assertion library)
- Microsoft.NET.Test.Sdk (test runner)
- coverlet.collector (code coverage)
- FluentValidation (for validation testing)

**Key Components**:

- Unit tests for commands, queries, and handlers
- Integration tests for database operations
- Test fixtures and data builders

## Architectural Patterns

### Clean Architecture

The solution follows Clean Architecture principles:

- **Dependency Rule**: Inner layers don't depend on outer layers
- **Domain Independence**: Core business logic is framework-agnostic
- **Testability**: Business rules can be tested without external dependencies

### CQRS (Command Query Responsibility Segregation)

- **Commands**: Handle write operations (create, update, delete)
- **Queries**: Handle read operations (retrieve data)
- **Separation of Concerns**: Different models for reading and writing

### Dependency Injection

- All components use dependency injection for loose coupling
- Services are registered in the composition root (API project)

## Data Flow

1. **API Layer**: Receives HTTP requests and maps to commands/queries
2. **Application Layer**: Validates input, orchestrates business logic
3. **Domain Layer**: Contains core business rules and entities
4. **Infrastructure Layer**: Persists data to SQL Server database

## Deployment

The solution includes Docker support for containerized deployment:

- **Dockerfile**: Multi-stage build for the API application
- **Dockerfile.migration**: Specialized container for running migrations
- **docker-compose.yml**: Orchestrates database, migration, and API services
- **init.sql**: Database initialization script

## Development Workflow

1. Domain entities are defined in the Domain project
2. Commands/Queries are created in the Application project
3. Handlers implement the business logic
4. Controllers in API expose endpoints
5. Infrastructure provides data persistence
6. Tests validate all components

This architecture ensures maintainability, testability, and scalability while keeping business logic independent of external frameworks.
