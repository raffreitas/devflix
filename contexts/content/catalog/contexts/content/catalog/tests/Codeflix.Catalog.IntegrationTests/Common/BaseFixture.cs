using Codeflix.Catalog.Application;
using Codeflix.Catalog.Infra.Data.ES;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Codeflix.Catalog.IntegrationTests.Common;

public abstract class BaseFixture
{
    public IServiceProvider ServiceProvider { get; } = BuildServiceProvider();

    private static ServiceProvider BuildServiceProvider()
    {
        var services = new ServiceCollection();

        var inMemorySettings = new Dictionary<string, string?>()
        {
            { "ConnectionStrings:ElasticSearch", "http://localhost:9201" }
        };

        IConfiguration configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(inMemorySettings)
            .Build();

        services
            .AddUseCases()
            .AddElasticSearch(configuration)
            .AddRepositories();

        return services.BuildServiceProvider();
    }
}