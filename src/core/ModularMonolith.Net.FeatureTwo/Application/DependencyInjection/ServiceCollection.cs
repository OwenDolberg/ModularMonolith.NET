using Microsoft.Extensions.DependencyInjection;

namespace ModularMonolith.Net.FeatureTwo.Application.DependencyInjection;

public static class ServiceCollection
{
    public static IServiceCollection AddFeatureTwoApplication(this IServiceCollection services)
    {
        // Add application services
        return services;
    }
}