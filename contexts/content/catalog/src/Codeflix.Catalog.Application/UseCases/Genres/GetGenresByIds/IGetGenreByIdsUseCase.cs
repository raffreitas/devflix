using Codeflix.Catalog.Application.UseCases.Genres.Common;

using MediatR;

namespace Codeflix.Catalog.Application.UseCases.Genres.GetGenresByIds;

public interface IGetGenreByIdsUseCase : IRequestHandler<GetGenreByIdsInput, IEnumerable<GenreModelOutput>>
{
}