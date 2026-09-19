using Devflix.Content.Admin.Application.UseCases.Genres.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Genres.UpdateGenre;
public record UpdateGenreInput(
    Guid Id,
    string Name,
    bool? IsActive = null,
    List<Guid>? CategoriesIds = null
) : IRequest<GenreModelOutput>;
