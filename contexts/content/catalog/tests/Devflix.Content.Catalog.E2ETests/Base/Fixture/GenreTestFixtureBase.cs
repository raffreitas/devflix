using Elastic.Clients.Elasticsearch;

using Devflix.Content.Catalog.Api;
using Devflix.Content.Catalog.Infra.Data.ES.Models;
using Devflix.Content.Catalog.Tests.Shared;

using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Devflix.Content.Catalog.E2ETests.Base.Fixture;

public class GenreTestFixtureBase : IDisposable
{
    protected CustomWebApplicationFactory<Program> WebApplicationFactory { get; }
    public ElasticsearchClient ElasticClient { get; }
    public GenreDataGenerator DataGenerator { get; } = new();

    protected GenreTestFixtureBase()
    {
        WebApplicationFactory = new CustomWebApplicationFactory<Program>();
        _ = WebApplicationFactory.CreateClient(new WebApplicationFactoryClientOptions
        {
            BaseAddress = new Uri(CustomWebApplicationFactory<Program>.BaseUrl)
        });
        ElasticClient = WebApplicationFactory.Services.GetRequiredService<ElasticsearchClient>();
        ElasticClient.CreateGenreIndexAsync().GetAwaiter().GetResult();
    }

    public List<GenreModel> GetGenreModelList(int count = 10) => DataGenerator.GetGenreModelList(count).ToList();

    public void DeleteAll() => ElasticClient.DeleteDocuments<GenreModel>();

    public void Dispose() => ElasticClient.DeleteGenreIndex();
}