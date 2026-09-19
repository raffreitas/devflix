using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Genres.ListGenres;

public interface IListGenresUseCase : IRequestHandler<ListGenresInput, ListGenresOutput>
{
}
