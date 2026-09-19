using Devflix.Content.Catalog.E2ETests.Base.Fixture;

using Microsoft.Extensions.DependencyInjection;

namespace Devflix.Content.Catalog.E2ETests.GraphQL.Categories.Common;

public class CategoryTestFixture : CategoryTestFixtureBase
{
    public CatalogClient GraphQlClient { get; }

    public CategoryTestFixture()
    {
        GraphQlClient = WebApplicationFactory.Services.GetRequiredService<CatalogClient>();
    }
}