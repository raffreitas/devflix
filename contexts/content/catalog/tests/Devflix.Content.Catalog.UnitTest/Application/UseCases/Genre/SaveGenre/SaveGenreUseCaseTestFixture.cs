using Devflix.Content.Catalog.UnitTests.Application.UseCases.Genre.Common;

using Devflix.Content.Catalog.Application.UseCases.Genres.SaveGenre;

namespace Devflix.Content.Catalog.UnitTests.Application.UseCases.Genre.SaveGenre;

public sealed class SaveGenreUseCaseTestFixture : GenreUseCaseTestFixture
{
    public SaveGenreInput GetValidInput() => DataGenerator.GetValidSaveGenreInput();

    public SaveGenreInput GetInvalidInput() => DataGenerator.GetInvalidSaveGenreInput();
}