using Devflix.Content.Admin.Infra.Data.EF;
using Devflix.Content.Admin.Infra.Messaging;
using Devflix.Content.Admin.Infra.Storage;

namespace Devflix.Content.Admin.Api.Configurations;

internal static class InfrastructureConfiguration
{
    public static IServiceCollection AddInfrastructureConfiguration(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDatabaseConfiguration(configuration);
        services.AddMessagingConfiguration(configuration);
        services.AddStorageConfiguration();

        return services;
    }
}