using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Application.UseCases.Categories.Common;

using Devflix.Content.Admin.Domain.Entities;
using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.Categories.CreateCategory;

public class CreateCategoryUseCase(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    : ICreateCategoryUseCase
{
    public async Task<CategoryModelOutput> Handle(CreateCategoryInput input, CancellationToken cancellationToken)
    {
        var category = new Category(input.Name, input.Description, input.IsActive);

        await categoryRepository.Insert(category, cancellationToken);
        await unitOfWork.Commit(cancellationToken);

        return CategoryModelOutput.FromCategory(category);
    }
}