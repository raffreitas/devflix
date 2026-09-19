using Codeflix.Catalog.Application.Common;
using Codeflix.Catalog.Application.UseCases.Categories.Common;

using MediatR;

namespace Codeflix.Catalog.Application.UseCases.Categories.SearchCategory;

public interface ISearchCategoryUseCase
    : IRequestHandler<SearchCategoryInput, SearchListOutput<CategoryModelOutput>>
{
}
