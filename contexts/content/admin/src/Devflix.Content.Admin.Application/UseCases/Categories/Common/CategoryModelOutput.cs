using Devflix.Content.Admin.Domain.Entities;

namespace Devflix.Content.Admin.Application.UseCases.Categories.Common;

public record CategoryModelOutput(
    Guid Id,
    string Name,
    string Description,
    bool IsActive,
    DateTime CreatedAt)
{
    public static CategoryModelOutput FromCategory(Category category)
        => new(
            Id: category.Id,
            Name: category.Name,
            Description: category.Description,
            IsActive: category.IsActive,
            CreatedAt: category.CreatedAt);
}