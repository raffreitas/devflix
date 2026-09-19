using Codeflix.Catalog.Application.UseCases.Categories.Common;

using MediatR;

namespace Codeflix.Catalog.Application.UseCases.Categories.SaveCategory;
public interface ISaveCategoryUseCase : IRequestHandler<SaveCategoryInput, CategoryModelOutput>
{
}
