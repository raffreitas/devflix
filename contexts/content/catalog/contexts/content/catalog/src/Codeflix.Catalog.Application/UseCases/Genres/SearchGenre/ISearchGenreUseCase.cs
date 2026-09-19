using Codeflix.Catalog.Application.Common;
using Codeflix.Catalog.Application.UseCases.Genres.Common;

using MediatR;

namespace Codeflix.Catalog.Application.UseCases.Genres.SearchGenre;

public interface ISearchGenreUseCase : IRequestHandler<SearchGenreInput, SearchListOutput<GenreModelOutput>>
{
}