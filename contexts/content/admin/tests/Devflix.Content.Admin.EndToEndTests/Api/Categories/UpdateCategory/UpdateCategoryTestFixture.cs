using Devflix.Content.Admin.Api.Models.Categories;
using Devflix.Content.Admin.EndToEndTests.Api.Categories.Common;

namespace Devflix.Content.Admin.EndToEndTests.Api.Categories.UpdateCategory;

public class ApiTempInput(string name, string? description = null, bool? isActive = null)
{
    public string Name { get; set; } = name;
    public string? Description { get; set; } = description;
    public bool? IsActive { get; set; } = isActive;
}

[CollectionDefinition(nameof(UpdateCategoryTestFixture))]
public class UpdateCategoryTestFixtureCollection : ICollectionFixture<UpdateCategoryTestFixture>
{
}

public class UpdateCategoryTestFixture : CategoryBaseFixture
{
    public UpdateCategoryApiInput GetExampleInput()
    {
        return new(
             GetValidCategoryName(),
             GetValidCategoryDescription(),
             GetRandomBoolean()
         );
    }
}
