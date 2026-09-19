using Devflix.Content.Admin.Application.UseCases.Categories.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Categories.CreateCategory;
public interface ICreateCategoryUseCase : IRequestHandler<CreateCategoryInput, CategoryModelOutput>
{
}