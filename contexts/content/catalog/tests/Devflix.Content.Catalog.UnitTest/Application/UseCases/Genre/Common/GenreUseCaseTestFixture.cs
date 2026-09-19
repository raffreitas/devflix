using Devflix.Content.Catalog.Domain.Repositories;
using Devflix.Content.Catalog.Tests.Shared;

using NSubstitute;

namespace Devflix.Content.Catalog.UnitTests.Application.UseCases.Genre.Common;

public class GenreUseCaseTestFixture
{
    public GenreDataGenerator DataGenerator { get; } = new();

    public IGenreRepository GetMockRepository() => Substitute.For<IGenreRepository>();

    public global::Devflix.Content.Catalog.Domain.Entities.Genre GetValidGenre() => DataGenerator.GetValidGenre();

    public List<global::Devflix.Content.Catalog.Domain.Entities.Genre> GetGenreList(int length = 10)
        => DataGenerator.GetGenreList(length);
}

[CollectionDefinition(nameof(GenreUseCaseTestFixture))]
public sealed class GenreUseCateTestFixtureCollection : ICollectionFixture<GenreUseCaseTestFixture>
{
}