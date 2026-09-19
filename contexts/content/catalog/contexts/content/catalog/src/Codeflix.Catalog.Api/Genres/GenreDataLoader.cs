using Codeflix.Catalog.Application.UseCases.Genres.GetGenresByIds;

using MediatR;

namespace Codeflix.Catalog.Api.Genres;

internal static class GenreDataLoaders
{
    [DataLoader]
    public static async Task<Dictionary<Guid, GenrePayload>> GetGenreByIdAsync(
        IReadOnlyList<Guid> ids,
        IMediator mediator,
        CancellationToken cancellationToken)
    {
        var genreIds = ids.ToArray();

        var result = await mediator.Send(
            new GetGenreByIdsInput(genreIds),
            cancellationToken);

        return result.ToDictionary(
            x => x.Id,
            GenrePayload.FromGenreModelOutput);
    }
}