using Devflix.Content.Admin.Application.UseCases.Categories.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Categories.UpdateCategory;
public interface IUpdateCategoryUseCase : IRequestHandler<UpdateCategoryInput, CategoryModelOutput>
{
}
