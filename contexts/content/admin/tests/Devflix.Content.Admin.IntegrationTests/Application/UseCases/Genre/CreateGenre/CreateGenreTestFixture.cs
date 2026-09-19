using Devflix.Content.Admin.IntegrationTests.Application.UseCases.Genre.Common;

using Devflix.Content.Admin.Application.UseCases.Genres.CreateGenre;

namespace Devflix.Content.Admin.IntegrationTests.Application.UseCases.Genre.CreateGenre;

[CollectionDefinition(nameof(CreateGenreTestFixture))]
public class CreateGenreTestFixtureCollection
    : ICollectionFixture<CreateGenreTestFixture>
{
}

public class CreateGenreTestFixture
    : GenreUseCasesBaseFixture
{
    public CreateGenreInput GetExampleInput()
        => new CreateGenreInput(
            GetValidGenreName(),
            GetRandomBoolean()
        );
}