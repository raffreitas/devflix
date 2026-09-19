using Codeflix.Catalog.Domain.Entities;
using Codeflix.Catalog.Tests.Shared;

namespace Codeflix.Catalog.UnitTests.Domain.Entities.Categories;

public sealed class CategoryTestFixture
{
    public CategoryDataGenerator DataGenerator { get; } = new();

    public Category GetValidCategory() => DataGenerator.GetValidCategory();
}

[CollectionDefinition(nameof(CategoryTestFixture))]
public class CategoryTestFixtureCollection : ICollectionFixture<CategoryTestFixture>
{
}