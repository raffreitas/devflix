using Devflix.Content.Catalog.Application.Common;
using Devflix.Content.Catalog.Application.UseCases.Categories.Common;

using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Categories.SearchCategory;

public interface ISearchCategoryUseCase
    : IRequestHandler<SearchCategoryInput, SearchListOutput<CategoryModelOutput>>
{
}
