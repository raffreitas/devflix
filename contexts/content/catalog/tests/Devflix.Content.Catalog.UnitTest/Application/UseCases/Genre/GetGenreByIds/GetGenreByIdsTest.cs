using Devflix.Content.Catalog.UnitTests.Application.UseCases.Genre.Common;

using Devflix.Content.Catalog.Application.UseCases.Genres.GetGenresByIds;

using FluentAssertions;

using NSubstitute;

namespace Devflix.Content.Catalog.UnitTests.Application.UseCases.Genre.GetGenreByIds;

[Trait("Application", "[UseCase] GetGenreByIds")]
[Collection(nameof(GenreUseCaseTestFixture))]
public sealed class GetGenreByIdsTest(GenreUseCaseTestFixture fixture)
{
    [Fact(DisplayName = nameof(Handle_WhenReceivesValidInput_ReturnsGenres))]
    public async Task Handle_WhenReceivesValidInput_ReturnsGenres()
    {
        var repository = fixture.GetMockRepository();
        var useCase = new GetGenreByIdsUseCase(repository);
        var genres = fixture.GetGenreList();
        var expectedOutput = genres.Select(genre => new
        {
            genre.Id,
            genre.Name,
            genre.CreatedAt,
            genre.IsActive,
            Categories = genre.Categories.Select(category => new { category.Id, category.Name })
        }).ToList();
        var ids = expectedOutput.Select(g => g.Id).ToList();
        var input = new GetGenreByIdsInput(ids);
        repository.GetByIdsAsync(
                Arg.Any<IEnumerable<Guid>>(),
                Arg.Any<CancellationToken>())
            .Returns(genres.ToList());

        var output = await useCase.Handle(input, CancellationToken.None);

        output.Should().BeEquivalentTo(expectedOutput);
    }
}