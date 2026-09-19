using Devflix.Content.Catalog.Application.UseCases.Genres.SearchGenre;
using Devflix.Content.Catalog.Domain.Repositories.DTOs;
using Devflix.Content.Catalog.UnitTests.Application.UseCases.Genre.Common;

namespace Devflix.Content.Catalog.UnitTests.Application.UseCases.Genre.SearchGenre;

public sealed class SearchGenreUseCaseTestFixture : GenreUseCaseTestFixture
{
    public SearchGenreInput GetSearchGenreInput()
    {
        var random = new Random();
        return new SearchGenreInput(
            Page: random.Next(1, 10),
            PerPage: random.Next(1, 10),
            Search: DataGenerator.Faker.Commerce.ProductName(),
            OrderBy: DataGenerator.Faker.Commerce.ProductName(),
            Order: random.Next(0, 1) == 0 ? SearchOrder.Asc : SearchOrder.Desc
        );
    }
}