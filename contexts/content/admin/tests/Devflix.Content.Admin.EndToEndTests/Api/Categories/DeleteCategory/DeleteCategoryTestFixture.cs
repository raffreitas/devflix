using Devflix.Content.Admin.EndToEndTests.Api.Categories.Common;

namespace Devflix.Content.Admin.EndToEndTests.Api.Categories.DeleteCategory;

[CollectionDefinition(nameof(DeleteCategoryTestFixture))]
public class DeleteCategoryTestFixtureCollection : ICollectionFixture<DeleteCategoryTestFixture> { }

public class DeleteCategoryTestFixture : CategoryBaseFixture
{
}
