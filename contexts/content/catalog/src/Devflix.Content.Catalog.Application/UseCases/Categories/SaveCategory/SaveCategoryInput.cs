using Devflix.Content.Catalog.Application.UseCases.Categories.Common;

using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Categories.SaveCategory;

public record SaveCategoryInput(
    Guid Id,
    string Name,
    string? Description,
    DateTime CreatedAt,
    bool IsActive) : IRequest<CategoryModelOutput>;