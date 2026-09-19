using MediatR;

namespace Codeflix.Catalog.Application.UseCases.Categories.DeleteCategory;
public interface IDeleteCategoryUseCase : IRequestHandler<DeleteCategoryInput>
{
}
