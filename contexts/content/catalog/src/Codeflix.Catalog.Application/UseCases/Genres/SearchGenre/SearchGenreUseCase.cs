using Codeflix.Catalog.Application.Common;
using Codeflix.Catalog.Application.UseCases.Genres.Common;

using Codeflix.Catalog.Domain.Repositories;

namespace Codeflix.Catalog.Application.UseCases.Genres.SearchGenre;

public sealed class SearchGenreUseCase(IGenreRepository genreRepository) : ISearchGenreUseCase
{
    public async Task<SearchListOutput<GenreModelOutput>> Handle(SearchGenreInput request,
        CancellationToken cancellationToken)
    {
        var searchInput = request.ToSearchInput();

        var categories = await genreRepository.SearchAsync(searchInput, cancellationToken);

        return new SearchListOutput<GenreModelOutput>(
            categories.CurrentPage,
            categories.PerPage,
            categories.Total,
            [.. categories.Items.Select(GenreModelOutput.FromGenre)]
        );
    }
}