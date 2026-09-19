namespace Devflix.Content.Admin.Api.Models.Genres;

public sealed record UpdateGenreApiInput(string Name, bool? IsActive = null, List<Guid>? CategoriesId = null);