using Microsoft.Extensions.DependencyInjection;

namespace ModularMonolith.Net.FeatureOne.Infrastructure.DependencyInjection;

public static class FeatureServiceCollection
{
    public static IServiceCollection AddFeatureOneInfrastructure(this IServiceCollection services)
    {
        // Add infrastructure services
        return services;
    }
}