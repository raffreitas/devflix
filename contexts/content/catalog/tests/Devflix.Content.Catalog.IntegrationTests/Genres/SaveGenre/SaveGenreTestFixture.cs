using Devflix.Content.Catalog.IntegrationTests.Genres.Common;

using Devflix.Content.Catalog.Application.UseCases.Genres.SaveGenre;

namespace Devflix.Content.Catalog.IntegrationTests.Genres.SaveGenre;

public sealed class SaveGenreTestFixture : GenreTestFixture
{
    public SaveGenreInput GetValidInput() => DataGenerator.GetValidSaveGenreInput();

    public SaveGenreInput GetInvalidInput() => DataGenerator.GetInvalidSaveGenreInput();
}

[CollectionDefinition(nameof(SaveGenreTestFixture))]
public class SaveGenreTestFixtureCollection : ICollectionFixture<SaveGenreTestFixture>
{
}