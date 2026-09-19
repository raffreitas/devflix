using Devflix.Content.Admin.UnitTests.Application.Genres.Common;

namespace Devflix.Content.Admin.UnitTests.Application.Genres.GetGenre;

[CollectionDefinition(nameof(GetGenreTestFixture))]
public class GetGenreTestFixtureCollection : ICollectionFixture<GetGenreTestFixture>
{
}

public class GetGenreTestFixture : GenreUseCasesBaseFixture
{
}
