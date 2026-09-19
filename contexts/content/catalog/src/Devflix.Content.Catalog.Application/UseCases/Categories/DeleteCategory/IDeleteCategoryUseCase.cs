using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Categories.DeleteCategory;
public interface IDeleteCategoryUseCase : IRequestHandler<DeleteCategoryInput>
{
}
