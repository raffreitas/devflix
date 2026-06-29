using Codeflix.Catalog.Application.UseCases.Genres.Common;

using MediatR;

namespace Codeflix.Catalog.Application.UseCases.Genres.SaveGenre;

public interface ISaveGenreUseCase : IRequestHandler<SaveGenreInput, GenreModelOutput>
{
}