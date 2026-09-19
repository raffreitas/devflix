using Codeflix.Catalog.Application.UseCases.Categories.Common;

using Codeflix.Catalog.Domain.Entities;
using Codeflix.Catalog.Domain.Repositories;

namespace Codeflix.Catalog.Application.UseCases.Categories.SaveCategory;

public class SaveCategoryUseCase(ICategoryRepository categoryRepository) : ISaveCategoryUseCase
{
    public async Task<CategoryModelOutput> Handle(SaveCategoryInput request, CancellationToken cancellationToken)
    {
        var category = new Category(request.Id, request.Name, request.Description, request.CreatedAt, request.IsActive);

        await categoryRepository.SaveAsync(category, cancellationToken);

        return CategoryModelOutput.FromCategory(category);
    }
}