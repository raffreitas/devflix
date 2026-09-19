using Devflix.Content.Catalog.Api.Common;

using Devflix.Content.Catalog.Application.Common;
using Devflix.Content.Catalog.Application.UseCases.Categories.Common;

namespace Devflix.Content.Catalog.Api.Categories;

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