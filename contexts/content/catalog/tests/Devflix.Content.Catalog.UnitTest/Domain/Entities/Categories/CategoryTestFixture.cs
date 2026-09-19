using Devflix.Content.Catalog.Domain.Entities;
using Devflix.Content.Catalog.Tests.Shared;

namespace Devflix.Content.Catalog.UnitTests.Domain.Entities.Categories;

public sealed class CategoryTestFixture
{
    public CategoryDataGenerator DataGenerator { get; } = new();

    public Category GetValidCategory() => DataGenerator.GetValidCategory();
}

[CollectionDefinition(nameof(CategoryTestFixture))]
public class CategoryTestFixtureCollection : ICollectionFixture<CategoryTestFixture>
{
}