using Codeflix.Catalog.Application.UseCases.Genres.Common;

using Codeflix.Catalog.Domain.Repositories;

namespace Codeflix.Catalog.Application.UseCases.Genres.GetGenresByIds;

public sealed class GetGenreByIdsUseCase(IGenreRepository repository) : IGetGenreByIdsUseCase
{
    public async Task<IEnumerable<GenreModelOutput>> Handle(GetGenreByIdsInput request,
        CancellationToken cancellationToken)
    {
        var genres = await repository.GetByIdsAsync(request.Ids, cancellationToken);

        return genres.Select(GenreModelOutput.FromGenre);
    }
}