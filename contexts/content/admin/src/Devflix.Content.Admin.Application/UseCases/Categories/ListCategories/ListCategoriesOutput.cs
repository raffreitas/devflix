using Devflix.Content.Admin.Application.Common;
using Devflix.Content.Admin.Application.UseCases.Categories.Common;

namespace Devflix.Content.Admin.Application.UseCases.Categories.ListCategories;

public record ListCategoriesOutput(
    int Page,
    int PerPage,
    int Total,
    IReadOnlyList<CategoryModelOutput> Items)
    : PaginatedListOutput<CategoryModelOutput>(Page, PerPage, Total, Items);
