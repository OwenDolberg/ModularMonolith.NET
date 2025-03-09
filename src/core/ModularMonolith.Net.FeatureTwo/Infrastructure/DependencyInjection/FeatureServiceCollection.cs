using Microsoft.Extensions.DependencyInjection;

namespace ModularMonolith.Net.FeatureTwo.Infrastructure.DependencyInjection;

public static class FeatureServiceCollection
{
    public static IServiceCollection AddFeatureTwoInfrastructure(this IServiceCollection services)
    {
        // Add infrastructure services
        return services;
    }
}