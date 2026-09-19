using Devflix.Content.Catalog.Application.UseCases.Categories.SearchCategory;
using Devflix.Content.Catalog.Domain.Entities;
using Devflix.Content.Catalog.Domain.Repositories.DTOs;
using Devflix.Content.Catalog.UnitTests.Application.UseCases.Categories.Common;

namespace Devflix.Content.Catalog.UnitTests.Application.UseCases.Categories.SearchCategory;

public class SearchCategoryTestFixture : CategoryUseCaseFixture
{
    public SearchCategoryInput GetSearchInput()
    {
        return new SearchCategoryInput(
            Page: DataGenerator.Faker.Random.Int(1, 10),
            PerPage: DataGenerator.Faker.Random.Int(10, 20),
            Search: DataGenerator.Faker.Commerce.ProductName(),
            OrderBy: DataGenerator.Faker.Commerce.ProductName(),
            Order: DataGenerator.Faker.PickRandom(SearchOrder.Asc, SearchOrder.Desc)
        );
    }

    public List<Category> GetCategoriesList(int length = 10)
        => [.. Enumerable.Range(0, length).Select(_ => GetValidCategory())];
}

[CollectionDefinition(nameof(SearchCategoryTestFixture))]
public class SearchCategoryTestFixtureCollection
    : ICollectionFixture<SearchCategoryTestFixture>
{
}