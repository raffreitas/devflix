using Devflix.Content.Admin.Application.Interfaces;

using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.Genres.DeleteGenre;

public class DeleteGenreUseCase(IGenreRepository genreRepository, IUnitOfWork unitOfWork) : IDeleteGenreUseCase
{
    public async Task Handle(DeleteGenreInput request, CancellationToken cancellationToken)
    {
        var genre = await genreRepository.Get(request.Id, cancellationToken);
        await genreRepository.Delete(genre, cancellationToken);
        await unitOfWork.Commit(cancellationToken);
    }
}
