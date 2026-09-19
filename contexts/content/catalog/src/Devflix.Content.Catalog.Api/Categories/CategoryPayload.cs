using Devflix.Content.Catalog.Application.UseCases.Categories.Common;

namespace Devflix.Content.Catalog.Api.Categories;

public sealed record CategoryPayload(
    Guid Id,
    string Name,
    string? Description,
    DateTime CreatedAt,
    bool IsActive
)
{
    public static CategoryPayload FromCategoryModelOutput(CategoryModelOutput output) => new(
        output.Id,
        output.Name,
        output.Description,
        output.CreatedAt,
        output.IsActive
    );
};