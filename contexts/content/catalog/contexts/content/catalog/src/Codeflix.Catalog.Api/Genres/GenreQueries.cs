using Codeflix.Catalog.Application.UseCases.Genres.SearchGenre;
using Codeflix.Catalog.Domain.Repositories.DTOs;

using HotChocolate.Resolvers;

using MediatR;

namespace Codeflix.Catalog.Api.Genres;

[ExtendObjectType(OperationTypeNames.Query)]
public sealed class GenreQueries
{
    public async Task<SearchGenrePayload> GetGenresAsync(
        [Service] IMediator mediator,
        int page = 1,
        int perPage = 10,
        string search = "",
        string sort = "",
        SearchOrder direction = SearchOrder.Asc,
        CancellationToken cancellationToken = default)
    {
        var input = new SearchGenreInput(page, perPage, search, sort, direction);
        var output = await mediator.Send(input, cancellationToken);
        return SearchGenrePayload.FromSearchListOutput(output);
    }

    public async Task<GenrePayload?> GetGenreAsync(
        Guid id,
        IResolverContext context,
        IGenreByIdDataLoader genreById,
        [Service] IMediator mediator,
        CancellationToken cancellationToken = default)
    {
        return await genreById.LoadAsync(id, cancellationToken);
    }
}