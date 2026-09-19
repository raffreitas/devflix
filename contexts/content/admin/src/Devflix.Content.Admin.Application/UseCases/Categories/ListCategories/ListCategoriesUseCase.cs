using Devflix.Content.Admin.Application.UseCases.Categories.Common;

using Devflix.Content.Admin.Domain.Repositories;
using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

namespace Devflix.Content.Admin.Application.UseCases.Categories.ListCategories;
public class ListCategoriesUseCase(ICategoryRepository categoryRepository) : IListCategoriesUseCase
{
    public async Task<ListCategoriesOutput> Handle(ListCategoriesInput request, CancellationToken cancellationToken)
    {
        var searchInput = new SearchInput(
                Page: request.Page,
                PerPage: request.PerPage,
                Search: request.Search,
                OrderBy: request.Sort,
                Order: request.Dir);

        var searchOutput = await categoryRepository.Search(searchInput, cancellationToken);

        return new ListCategoriesOutput(
            searchOutput.CurrentPage,
            searchOutput.PerPage,
            searchOutput.Total,
            [.. searchOutput.Items.Select(CategoryModelOutput.FromCategory)]
        );
    }
}
