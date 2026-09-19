using Devflix.Content.Admin.EndToEndTests.Api.Genres.Common;

namespace Devflix.Content.Admin.EndToEndTests.Api.Genres.UpdateGenre;

[CollectionDefinition(nameof(UpdateGenreApiTestFixture))]
public class UpdateGenreApiTestFixtureCollection
    : ICollectionFixture<UpdateGenreApiTestFixture>
{}

public class UpdateGenreApiTestFixture
    : GenreBaseFixture
{
}
