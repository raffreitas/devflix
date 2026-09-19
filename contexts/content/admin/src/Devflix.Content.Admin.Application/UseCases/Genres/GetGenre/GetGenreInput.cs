using Devflix.Content.Admin.Application.UseCases.Genres.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Genres.GetGenre;
public record GetGenreInput(Guid Id) : IRequest<GenreModelOutput>
{
}
