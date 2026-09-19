using Codeflix.Catalog.Application.Common;
using Codeflix.Catalog.Application.UseCases.Categories.Common;

using Codeflix.Catalog.Domain.Repositories.DTOs;

using MediatR;

namespace Codeflix.Catalog.Application.UseCases.Categories.SearchCategory;

public record SearchCategoryInput(
    int Page = 1,
    int PerPage = 20,
    string Search = "",
    string OrderBy = "",
    SearchOrder Order = SearchOrder.Asc)
    : SearchListInput(Page, PerPage, Search, OrderBy, Order), IRequest<SearchListOutput<CategoryModelOutput>>;