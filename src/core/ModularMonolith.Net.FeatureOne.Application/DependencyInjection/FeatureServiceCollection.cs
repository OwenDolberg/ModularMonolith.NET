using Microsoft.Extensions.DependencyInjection;
using ModularMonolith.Net.FeatureOne.Application.Interfaces;
using ModularMonolith.Net.FeatureOne.Application.Services;

namespace ModularMonolith.Net.FeatureOne.Application.DependencyInjection;

public static class FeatureServiceCollection
{
    public static IServiceCollection AddFeatureOneApplication(this IServiceCollection services)
    {
        // Add application services
        // services.AddScoped<IFeatureOneService, FeatureOneService>();
        return services;
    }
}