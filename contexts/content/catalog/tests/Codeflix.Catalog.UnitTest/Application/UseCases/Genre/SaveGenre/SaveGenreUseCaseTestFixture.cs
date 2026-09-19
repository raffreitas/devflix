using Codeflix.Catalog.UnitTests.Application.UseCases.Genre.Common;

using Codeflix.Catalog.Application.UseCases.Genres.SaveGenre;

namespace Codeflix.Catalog.UnitTests.Application.UseCases.Genre.SaveGenre;

public sealed class SaveGenreUseCaseTestFixture : GenreUseCaseTestFixture
{
    public SaveGenreInput GetValidInput() => DataGenerator.GetValidSaveGenreInput();

    public SaveGenreInput GetInvalidInput() => DataGenerator.GetInvalidSaveGenreInput();
}