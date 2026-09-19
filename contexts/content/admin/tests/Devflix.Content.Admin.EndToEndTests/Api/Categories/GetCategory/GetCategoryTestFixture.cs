using Devflix.Content.Admin.EndToEndTests.Api.Categories.Common;

using Devflix.Content.Admin.Application.UseCases.Categories.Common;

namespace Devflix.Content.Admin.EndToEndTests.Api.Categories.GetCategory;

public class GetCategoryResponse
{
    public CategoryModelOutput Data { get; set; } = null!;
}

[CollectionDefinition(nameof(GetCategoryTestFixture))]
public class GetCategoryTestFixtureCollection : ICollectionFixture<GetCategoryTestFixture> { }
public class GetCategoryTestFixture : CategoryBaseFixture
{
}
