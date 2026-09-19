using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Categories.ListCategories;
public interface IListCategoriesUseCase : IRequestHandler<ListCategoriesInput, ListCategoriesOutput>
{
}
