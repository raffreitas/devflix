using Devflix.Content.Admin.EndToEndTests.Api.Categories.Common;

using Devflix.Content.Admin.Application.UseCases.Categories.CreateCategory;

namespace Devflix.Content.Admin.EndToEndTests.Api.Categories.CreateCategory;

[CollectionDefinition(nameof(CreateCategoryTestFixture))]
public class CreateCategoryTestFixtureCollection : ICollectionFixture<CreateCategoryTestFixture>
{ }
public class CreateCategoryTestFixture : CategoryBaseFixture
{
    public CreateCategoryInput GetExampleInput()
    {
        return new(
            GetValidCategoryName(),
            GetValidCategoryDescription(),
            GetRandomBoolean()
        );
    }
}
