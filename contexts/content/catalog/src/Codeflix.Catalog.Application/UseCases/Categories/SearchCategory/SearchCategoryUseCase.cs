using Codeflix.Catalog.Application.Common;
using Codeflix.Catalog.Application.UseCases.Categories.Common;

using Codeflix.Catalog.Domain.Repositories;

namespace Codeflix.Catalog.Application.UseCases.Categories.SearchCategory;

public class SearchCategoryUseCase(ICategoryRepository categoryRepository)
    : ISearchCategoryUseCase
{
    public async Task<SearchListOutput<CategoryModelOutput>> Handle(
        SearchCategoryInput request,
        CancellationToken cancellationToken)
    {
        var searchInput = request.ToSearchInput();

        var categories = await categoryRepository.SearchAsync(searchInput, cancellationToken);

        return new SearchListOutput<CategoryModelOutput>(
            categories.CurrentPage,
            categories.PerPage,
            categories.Total,
            [.. categories.Items.Select(CategoryModelOutput.FromCategory)]
        );
    }
}