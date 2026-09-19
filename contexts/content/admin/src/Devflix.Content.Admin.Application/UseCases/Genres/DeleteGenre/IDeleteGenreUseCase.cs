using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Genres.DeleteGenre;

public interface IDeleteGenreUseCase : IRequestHandler<DeleteGenreInput> { }