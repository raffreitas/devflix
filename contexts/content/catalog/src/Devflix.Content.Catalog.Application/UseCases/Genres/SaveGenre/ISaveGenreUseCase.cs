using Devflix.Content.Catalog.Application.UseCases.Genres.Common;

using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Genres.SaveGenre;

public interface ISaveGenreUseCase : IRequestHandler<SaveGenreInput, GenreModelOutput>
{
}