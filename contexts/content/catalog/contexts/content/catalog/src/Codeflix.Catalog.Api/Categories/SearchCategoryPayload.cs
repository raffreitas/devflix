using Codeflix.Catalog.Api.Common;

using Codeflix.Catalog.Application.Common;
using Codeflix.Catalog.Application.UseCases.Categories.Common;

namespace Codeflix.Catalog.Api.Categories;

public sealed record SearchCategoryPayload : SearchPayload<CategoryPayload>
{
    public static SearchCategoryPayload FromSearchListOutput(SearchListOutput<CategoryModelOutput> output)
    {
        return new SearchCategoryPayload
        {
            CurrentPage = output.CurrentPage,
            PerPage = output.PerPage,
            Total = output.Total,
            Items = output.Items.Select(CategoryPayload.FromCategoryModelOutput).ToList()
        };
    }
};