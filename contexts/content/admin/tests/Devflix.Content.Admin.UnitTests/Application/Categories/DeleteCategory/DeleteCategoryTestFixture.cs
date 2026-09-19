using Devflix.Content.Admin.UnitTests.Application.Categories.Common;

namespace Devflix.Content.Admin.UnitTests.Application.Categories.DeleteCategory;

[CollectionDefinition(nameof(DeleteCategoryTestFixture))]
public class DeleteCategoryTestFixtureCollection : ICollectionFixture<DeleteCategoryTestFixture>
{
}

public class DeleteCategoryTestFixture : CategoryUseCasesBaseFixture
{
}