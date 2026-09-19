using Devflix.Content.Admin.IntegrationTests.Application.UseCases.Genre.Common;

namespace Devflix.Content.Admin.IntegrationTests.Application.UseCases.Genre.DeleteGenre;

[CollectionDefinition(nameof(DeleteGenreTestFixture))]
public class DeleteGenreTestFixtureCollection
    : ICollectionFixture<DeleteGenreTestFixture>
{ }

public class DeleteGenreTestFixture
    : GenreUseCasesBaseFixture
{
}
