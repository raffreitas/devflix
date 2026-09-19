using Devflix.Content.Admin.Application.UseCases.Categories.Common;

using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.Categories.GetCategory;

public class GetCategoryUseCase(ICategoryRepository categoryRepository) : IGetCategoryUseCase
{
    public async Task<CategoryModelOutput> Handle(GetCategoryInput request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.Get(request.Id, cancellationToken);

        return CategoryModelOutput.FromCategory(category);
    }
}