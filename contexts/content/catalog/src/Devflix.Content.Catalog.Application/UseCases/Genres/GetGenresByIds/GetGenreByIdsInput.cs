using Devflix.Content.Catalog.Application.UseCases.Genres.Common;

using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Genres.GetGenresByIds;

public sealed record GetGenreByIdsInput(
    IEnumerable<Guid> Ids
) : IRequest<IEnumerable<GenreModelOutput>>;