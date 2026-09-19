using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Categories.DeleteCategory;
internal interface IDeleteCategoryUseCase : IRequestHandler<DeleteCategoryInput>
{
}
