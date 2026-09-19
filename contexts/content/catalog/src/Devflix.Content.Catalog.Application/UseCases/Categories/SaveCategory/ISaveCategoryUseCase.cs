using Devflix.Content.Catalog.Application.UseCases.Categories.Common;

using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Categories.SaveCategory;
public interface ISaveCategoryUseCase : IRequestHandler<SaveCategoryInput, CategoryModelOutput>
{
}
