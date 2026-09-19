using Devflix.Content.Catalog.Application.Common;
using Devflix.Content.Catalog.Application.UseCases.Genres.Common;

using Devflix.Content.Catalog.Domain.Repositories;

namespace Devflix.Content.Catalog.Application.UseCases.Genres.SearchGenre;

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