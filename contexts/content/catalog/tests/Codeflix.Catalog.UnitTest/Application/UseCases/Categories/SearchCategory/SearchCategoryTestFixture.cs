using Codeflix.Catalog.Application.UseCases.Categories.SearchCategory;
using Codeflix.Catalog.Domain.Entities;
using Codeflix.Catalog.Domain.Repositories.DTOs;
using Codeflix.Catalog.UnitTests.Application.UseCases.Categories.Common;

namespace Codeflix.Catalog.UnitTests.Application.UseCases.Categories.SearchCategory;

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