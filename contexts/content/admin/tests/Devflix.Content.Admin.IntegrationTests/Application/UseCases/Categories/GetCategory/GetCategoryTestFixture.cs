using Devflix.Content.Admin.IntegrationTests.Application.UseCases.Categories.Common;

namespace Devflix.Content.Admin.IntegrationTests.Application.UseCases.Categories.GetCategory;

[CollectionDefinition(nameof(GetCategoryTestFixture))]
public class GetCategoryTestFixtureCollection : ICollectionFixture<GetCategoryTestFixture>
{
}

public class GetCategoryTestFixture : CategoryUseCasesBaseFixture
{
}
