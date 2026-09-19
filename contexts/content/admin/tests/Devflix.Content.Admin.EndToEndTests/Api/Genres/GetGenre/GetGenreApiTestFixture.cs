using Devflix.Content.Admin.EndToEndTests.Api.Genres.Common;

namespace Devflix.Content.Admin.EndToEndTests.Api.Genres.GetGenre;

[CollectionDefinition(nameof(GetGenreApiTestFixture))]
public class GetGenreApiTestFixtureCollection :
    ICollectionFixture<GetGenreApiTestFixture>
{ }

public class GetGenreApiTestFixture
    : GenreBaseFixture
{
}
