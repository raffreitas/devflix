using Devflix.Content.Catalog.Domain.Entities;
using Devflix.Content.Catalog.Domain.Repositories;
using Devflix.Content.Catalog.Tests.Shared;

using NSubstitute;

namespace Devflix.Content.Catalog.UnitTests.Application.UseCases.Categories.Common;

public class CategoryUseCaseFixture
{
    public CategoryDataGenerator DataGenerator { get; } = new();

    public ICategoryRepository GetMockRepository()
        => Substitute.For<ICategoryRepository>();

    public Category GetValidCategory() => DataGenerator.GetValidCategory();
}

[CollectionDefinition(nameof(CategoryUseCaseFixture))]
public class CategoryUseCaseFixtureCollection : ICollectionFixture<CategoryUseCaseFixture>
{
}