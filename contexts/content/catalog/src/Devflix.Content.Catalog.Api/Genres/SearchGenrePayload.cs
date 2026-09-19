using Devflix.Content.Catalog.Api.Common;

using Devflix.Content.Catalog.Application.Common;
using Devflix.Content.Catalog.Application.UseCases.Genres.Common;

namespace Devflix.Content.Catalog.Api.Genres;

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