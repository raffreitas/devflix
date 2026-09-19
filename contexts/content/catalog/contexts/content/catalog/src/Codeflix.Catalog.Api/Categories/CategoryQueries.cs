using Codeflix.Catalog.Application.UseCases.Categories.SearchCategory;
using Codeflix.Catalog.Domain.Repositories.DTOs;

using MediatR;

namespace Codeflix.Catalog.Api.Categories;

[ExtendObjectType(OperationTypeNames.Query)]
public sealed class CategoryQueries
{
    public async Task<SearchCategoryPayload> GetCategoriesAsync(
        [Service] IMediator mediator,
        int page = 1,
        int perPage = 10,
        string search = "",
        string sort = "",
        SearchOrder direction = SearchOrder.Asc,
        CancellationToken cancellationToken = default
    )
    {
        var input = new SearchCategoryInput(
            page,
            perPage,
            search,
            sort,
            direction
        );

        var output = await mediator.Send(input, cancellationToken);
        return SearchCategoryPayload.FromSearchListOutput(output);
    }
}