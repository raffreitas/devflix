using Devflix.Content.Admin.Infra.Data.EF;

using Microsoft.EntityFrameworkCore;

namespace Devflix.Content.Admin.Api.Configurations;

public static class ConnectionsConfiguration
{
    public static IServiceCollection AddAppConnections(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbConnection(configuration);
        return services;
    }

    private static IServiceCollection AddDbConnection(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("CatalogDb")!;
        services.AddDbContext<DevflixContentAdminDbContext>(options => options.UseMySQL(connectionString));

        return services;
    }
}