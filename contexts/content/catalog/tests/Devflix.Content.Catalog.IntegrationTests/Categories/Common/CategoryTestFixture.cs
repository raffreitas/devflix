using Devflix.Content.Catalog.IntegrationTests.Common;

using Elastic.Clients.Elasticsearch;

using Devflix.Content.Catalog.Domain.Entities;
using Devflix.Content.Catalog.Infra.Data.ES.Models;
using Devflix.Content.Catalog.Tests.Shared;

using Microsoft.Extensions.DependencyInjection;

namespace Devflix.Content.Catalog.IntegrationTests.Categories.Common;

public class CategoryTestFixture : BaseFixture, IDisposable
{
    public CategoryDataGenerator DataGenerator { get; } = new();
    public readonly ElasticsearchClient ElasticClient;

    public CategoryTestFixture()
    {
        ElasticClient = ServiceProvider.GetRequiredService<ElasticsearchClient>();
        ElasticClient.CreateCategoryIndexAsync().GetAwaiter().GetResult();
    }

    public Category GetValidCategory() => DataGenerator.GetValidCategory();

    public IList<CategoryModel> GetCategoryModelList(int length = 10)
        => DataGenerator.GetCategoryModelList(length);


    public void DeleteAll()
    {
        ElasticClient.DeleteDocuments<CategoryModel>();
    }

    public void Dispose()
    {
        ElasticClient.DeleteCategoryIndex();
    }
}

[CollectionDefinition(nameof(CategoryTestFixture))]
public class CategoryTestFixtureCollection : ICollectionFixture<CategoryTestFixture>
{
}