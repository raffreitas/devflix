using Devflix.Content.Admin.Application.UseCases.Genres.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Genres.UpdateGenre;
public interface IUpdateGenreUseCase : IRequestHandler<UpdateGenreInput, GenreModelOutput>
{
}
