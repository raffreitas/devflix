using Devflix.Content.Admin.UnitTests.Application.Genres.Common;

namespace Devflix.Content.Admin.UnitTests.Application.Genres.DeleteGenre;

[CollectionDefinition(nameof(DeleteGenreTestFixture))]
public class DeleteGenreTestFixtureCollection : ICollectionFixture<DeleteGenreTestFixture>
{
}

public class DeleteGenreTestFixture : GenreUseCasesBaseFixture
{
}
