using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Genres.DeleteGenre;

public sealed record DeleteGenreInput(Guid Id) : IRequest;