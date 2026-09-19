using Devflix.Content.Admin.Application.Common;

using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Categories.ListCategories;
public record ListCategoriesInput(
    int Page = 1,
    int PerPage = 15,
    string Search = "",
    string Sort = "",
    SearchOrder Dir = SearchOrder.Asc)
    : PaginatedListInput(Page, PerPage, Search, Sort, Dir), IRequest<ListCategoriesOutput>
{
    public ListCategoriesInput()
        : this(1, 15, "", "", SearchOrder.Asc)
    {
    }
}
