using Devflix.Content.Admin.EndToEndTests.Api.Genres.Common;

namespace Devflix.Content.Admin.EndToEndTests.Api.Genres.CreateGenre;

[CollectionDefinition(nameof(CreateGenreApiTestFixture))]
public class CreateGenreApiTestFixtureCollection
    : ICollectionFixture<CreateGenreApiTestFixture>
{ }

public class CreateGenreApiTestFixture
    : GenreBaseFixture
{
}
