using Devflix.Content.Admin.EndToEndTests.Api.Genres.Common;

namespace Devflix.Content.Admin.EndToEndTests.Api.Genres.DeleteGenre;

[CollectionDefinition(nameof(DeleteGenreTestApiFixture))]
public class DeleteGenreTestApiFixtureCollection
    : ICollectionFixture<DeleteGenreTestApiFixture>
{ }

public class DeleteGenreTestApiFixture
    : GenreBaseFixture
{
}
