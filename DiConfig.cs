using FileTypeValidator.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FileTypeValidator;

public static class DiConfig
{
    public static IServiceCollection UseFileTypeValidator(this IServiceCollection services)
    {
        services.AddScoped<IFileTypeValidator, Infrastructure.FileTypeValidator>();
        return services;
    }
}