using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace ElektronickePosudky.Application.Localization;

public sealed class DatabaseStringLocalizerFactory : IStringLocalizerFactory
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public DatabaseStringLocalizerFactory(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public IStringLocalizer Create(Type resourceSource)
    {
        return new DatabaseStringLocalizer(_httpContextAccessor);
    }

    public IStringLocalizer Create(string baseName, string location)
    {
        return new DatabaseStringLocalizer(_httpContextAccessor);
    }
}
