using Devflix.Content.Catalog.UnitTests.Application.UseCases.Categories.Common;

using Devflix.Content.Catalog.Application.UseCases.Categories.SaveCategory;

namespace Devflix.Content.Catalog.UnitTests.Application.UseCases.Categories.SaveCategory;

public class SaveCategoryFixture : CategoryUseCaseFixture
{
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
            DataGenerator.GetValidCategoryName(),
            DateTime.Now,
            DataGenerator.GetRandomBoolean()
        );
}

[CollectionDefinition(nameof(SaveCategoryFixture))]
public class SaveCategoryTestFixtureCollection
    : ICollectionFixture<SaveCategoryFixture>
{
}