using Devflix.Content.Admin.UnitTests.Application.Genres.Common;

namespace Devflix.Content.Admin.UnitTests.Application.Genres.UpdateGenre;

[CollectionDefinition(nameof(UpdateGenreTestFixture))]
public class UpdateGenreTestFixtureCollection : ICollectionFixture<UpdateGenreTestFixture> { }

public class UpdateGenreTestFixture : GenreUseCasesBaseFixture
{
}
