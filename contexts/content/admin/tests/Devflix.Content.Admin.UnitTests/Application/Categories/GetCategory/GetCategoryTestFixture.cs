using Devflix.Content.Admin.UnitTests.Application.Categories.Common;

namespace Devflix.Content.Admin.UnitTests.Application.Categories.GetCategory;

[CollectionDefinition(nameof(GetCategoryTestFixture))]
public class GetCategoryTestFixtureCollection : ICollectionFixture<GetCategoryTestFixture> { }

public class GetCategoryTestFixture : CategoryUseCasesBaseFixture
{
}