using Devflix.Content.Catalog.Application.UseCases.Categories.Common;

using Devflix.Content.Catalog.Domain.Entities;
using Devflix.Content.Catalog.Domain.Repositories;

namespace Devflix.Content.Catalog.Application.UseCases.Categories.SaveCategory;

public class SaveCategoryUseCase(ICategoryRepository categoryRepository) : ISaveCategoryUseCase
{
    public async Task<CategoryModelOutput> Handle(SaveCategoryInput request, CancellationToken cancellationToken)
    {
        var category = new Category(request.Id, request.Name, request.Description, request.CreatedAt, request.IsActive);

        await categoryRepository.SaveAsync(category, cancellationToken);

        return CategoryModelOutput.FromCategory(category);
    }
}