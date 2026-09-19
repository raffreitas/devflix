using Devflix.Content.Catalog.Application.Common;
using Devflix.Content.Catalog.Application.UseCases.Genres.Common;

using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Genres.SearchGenre;

public interface ISearchGenreUseCase : IRequestHandler<SearchGenreInput, SearchListOutput<GenreModelOutput>>
{
}