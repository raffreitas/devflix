using Devflix.Content.Catalog.Domain.Entities;
using Devflix.Content.Catalog.Tests.Shared;

namespace Devflix.Content.Catalog.UnitTests.Domain.Entities.Genres;

public sealed class GenreTestFixture
{
    private readonly GenreDataGenerator _dataGenerator = new();

    public Genre GetValidGenre() => _dataGenerator.GetValidGenre();
}