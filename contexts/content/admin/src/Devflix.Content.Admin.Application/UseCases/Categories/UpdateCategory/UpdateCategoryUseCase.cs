using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Application.UseCases.Categories.Common;

using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.Categories.UpdateCategory;
public class UpdateCategoryUseCase(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    : IUpdateCategoryUseCase
{
    public async Task<CategoryModelOutput> Handle(UpdateCategoryInput request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.Get(request.Id, cancellationToken);

        category.Update(request.Name, request.Description);

        if (
            request.IsActive is not null &&
            request.IsActive != category.IsActive)
        {
            if ((bool)request.IsActive!) category.Activate();
            else category.Deactivate();
        }

        await categoryRepository.Update(category, cancellationToken);
        await unitOfWork.Commit(cancellationToken);

        return CategoryModelOutput.FromCategory(category);
    }
}
