using Devflix.Content.Catalog.Application.UseCases.Genres.Common;

using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Genres.GetGenresByIds;

public interface IGetGenreByIdsUseCase : IRequestHandler<GetGenreByIdsInput, IEnumerable<GenreModelOutput>>
{
}