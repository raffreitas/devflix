using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Genres.DeleteGenre;

public interface IDeleteGenreUseCase : IRequestHandler<DeleteGenreInput>
{
}