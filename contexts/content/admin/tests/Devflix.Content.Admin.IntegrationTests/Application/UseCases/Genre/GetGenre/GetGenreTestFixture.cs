using Devflix.Content.Admin.IntegrationTests.Application.UseCases.Genre.Common;

namespace Devflix.Content.Admin.IntegrationTests.Application.UseCases.Genre.GetGenre;

[CollectionDefinition(nameof(GetGenreTestFixture))]
public class GetGenreTestFixtureCollection
    : ICollectionFixture<GetGenreTestFixture>
{ }
public class GetGenreTestFixture
    : GenreUseCasesBaseFixture
{

}
