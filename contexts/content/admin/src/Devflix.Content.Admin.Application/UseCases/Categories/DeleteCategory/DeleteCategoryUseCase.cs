using Devflix.Content.Admin.Application.Interfaces;

using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.Categories.DeleteCategory;
public class DeleteCategoryUseCase(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    : IDeleteCategoryUseCase
{
    public async Task Handle(DeleteCategoryInput request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.Get(request.Id, cancellationToken);

        await categoryRepository.Delete(category, cancellationToken);

        await unitOfWork.Commit(cancellationToken);
    }
}
