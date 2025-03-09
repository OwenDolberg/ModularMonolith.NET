using ModularMonolith.Net.FeatureOne.Application.DependencyInjection;
using ModularMonolith.Net.FeatureOne.Infrastructure.DependencyInjection;
using ModularMonolith.Net.FeatureTwo.Application.DependencyInjection;
using ModularMonolith.Net.FeatureTwo.Infrastructure.DependencyInjection;

namespace ModularMonolith.Net.Api.DependencyInjection;

public static class FeatureServiceCollection
{
    /// <summary>
    /// Why do we do this?
    /// So we can add all the features in one line in the Startup.cs!
    /// So we can easily add feature toggles! (e.g., if (env.IsDevelopment()) { ... })
    /// So we can easily order our dependencies!
    /// </summary>
    /// <param name="services"></param>
    public static void AddFeatures(this IServiceCollection services)
    {
        services.AddFeatureOneApplication();
        services.AddFeatureOneInfrastructure();
        services.AddFeatureTwoApplication();
        services.AddFeatureTwoInfrastructure();
    }
}