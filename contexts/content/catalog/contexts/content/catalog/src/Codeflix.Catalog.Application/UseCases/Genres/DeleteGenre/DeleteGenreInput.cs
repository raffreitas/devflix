using MediatR;

namespace Codeflix.Catalog.Application.UseCases.Genres.DeleteGenre;

public sealed record DeleteGenreInput(Guid Id) : IRequest;