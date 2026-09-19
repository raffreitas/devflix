using Codeflix.Catalog.Domain.Repositories;
using Codeflix.Catalog.Tests.Shared;

using NSubstitute;

namespace Codeflix.Catalog.UnitTests.Application.UseCases.Genre.Common;

public class GenreUseCaseTestFixture
{
    public GenreDataGenerator DataGenerator { get; } = new();

    public IGenreRepository GetMockRepository() => Substitute.For<IGenreRepository>();

    public global::Codeflix.Catalog.Domain.Entities.Genre GetValidGenre() => DataGenerator.GetValidGenre();

    public List<global::Codeflix.Catalog.Domain.Entities.Genre> GetGenreList(int length = 10)
        => DataGenerator.GetGenreList(length);
}

[CollectionDefinition(nameof(GenreUseCaseTestFixture))]
public sealed class GenreUseCateTestFixtureCollection : ICollectionFixture<GenreUseCaseTestFixture>
{
}