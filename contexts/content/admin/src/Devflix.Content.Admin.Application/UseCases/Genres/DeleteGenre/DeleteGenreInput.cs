using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Genres.DeleteGenre;
public record DeleteGenreInput(Guid Id) : IRequest
{
}
