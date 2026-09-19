using Codeflix.Catalog.Domain.Entities;
using Codeflix.Catalog.Tests.Shared;

namespace Codeflix.Catalog.UnitTests.Domain.Entities.Genres;

public sealed class GenreTestFixture
{
    private readonly GenreDataGenerator _dataGenerator = new();

    public Genre GetValidGenre() => _dataGenerator.GetValidGenre();
}