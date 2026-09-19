using Codeflix.Catalog.Api.Common;

using Codeflix.Catalog.Application.Common;
using Codeflix.Catalog.Application.UseCases.Genres.Common;

namespace Codeflix.Catalog.Api.Genres;

public sealed record SearchGenrePayload : SearchPayload<GenrePayload>
{
    public static SearchGenrePayload FromSearchListOutput(SearchListOutput<GenreModelOutput> output) => new()
    {
        CurrentPage = output.CurrentPage,
        PerPage = output.PerPage,
        Total = output.Total,
        Items = output.Items.Select(GenrePayload.FromGenreModelOutput).ToList()
    };
}