using Codeflix.Catalog.Domain.Repositories;

namespace Codeflix.Catalog.Application.UseCases.Genres.DeleteGenre;

public sealed class DeleteGenreUseCase(IGenreRepository genreRepository) : IDeleteGenreUseCase
{
    public async Task Handle(DeleteGenreInput request, CancellationToken cancellationToken)
    {
        await genreRepository.DeleteAsync(request.Id, cancellationToken);
    }
}