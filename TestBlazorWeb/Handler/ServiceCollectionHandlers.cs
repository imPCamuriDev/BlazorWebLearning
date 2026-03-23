using Microsoft.Extensions.DependencyInjection;
using TestBlazorWeb.Services.Counting;

namespace TestBlazorWeb.Handler;

public static class ServiceCollectionHandlers
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<CountingService>();

        return services;
    }
}