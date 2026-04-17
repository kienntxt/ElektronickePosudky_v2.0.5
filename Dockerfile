# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files
COPY ["src/ElektronickePosudky.API/ElektronickePosudky.API.csproj", "ElektronickePosudky.API/"]
COPY ["src/ElektronickePosudky.Application/ElektronickePosudky.Application.csproj", "ElektronickePosudky.Application/"]
COPY ["src/ElektronickePosudky.Domain/ElektronickePosudky.Domain.csproj", "ElektronickePosudky.Domain/"]
COPY ["src/ElektronickePosudky.Infrastructure/ElektronickePosudky.Infrastructure.csproj", "ElektronickePosudky.Infrastructure/"]

# Restore dependencies
RUN dotnet restore "ElektronickePosudky.API/ElektronickePosudky.API.csproj"

# Copy all source code
COPY src/ .

# Build application
RUN dotnet build "ElektronickePosudky.API/ElektronickePosudky.API.csproj" -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
RUN dotnet publish "ElektronickePosudky.API/ElektronickePosudky.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Create logs directory
RUN mkdir -p /app/logs

# Copy published application
COPY --from=publish /app/publish .

# Set environment to Production
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:80

# Expose port
EXPOSE 80

# Set the connection string environment variable
# This can be overridden at runtime with: docker run -e ConnectionStrings__DefaultConnection="your_connection_string"
ENV ConnectionStrings__DefaultConnection=""

# Health check
HEALTHCHECK --interval=30s --timeout=10s --start-period=40s --retries=3 \
    CMD dotnet /app/HealthCheck.dll 2>/dev/null || exit 1 || true

ENTRYPOINT ["dotnet", "ElektronickePosudky.API.dll"]
