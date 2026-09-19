using Devflix.Content.Catalog.IntegrationTests.Categories.Common;

using Devflix.Content.Catalog.Application.UseCases.Categories.SaveCategory;
using Devflix.Content.Catalog.Tests.Shared;

namespace Devflix.Content.Catalog.IntegrationTests.Categories.SaveCategory;

public class SaveCategoryTestFixture : CategoryTestFixture
{
    public CategoryDataGenerator DataGenerator { get; } = new();

    public SaveCategoryInput GetValidInput()
        => new(
            Guid.NewGuid(),
            DataGenerator.GetValidCategoryName(),
            DataGenerator.GetValidCategoryDescription(),
            DateTime.Now,
            DataGenerator.GetRandomBoolean()
        );

    public SaveCategoryInput GetInvalidInput()
        => new(
            Guid.NewGuid(),
            null!,
            DataGenerator.GetValidCategoryDescription(),
            DateTime.Now,
            DataGenerator.GetRandomBoolean()
        );
}