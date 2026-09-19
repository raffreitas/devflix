using Devflix.Content.Admin.Application.UseCases.Genres.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Genres.CreateGenre;

internal interface ICreateGenreUseCase : IRequestHandler<CreateGenreInput, GenreModelOutput>
{
}
