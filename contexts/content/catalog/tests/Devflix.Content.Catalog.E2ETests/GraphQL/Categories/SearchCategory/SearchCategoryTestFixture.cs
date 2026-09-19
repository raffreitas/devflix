using Devflix.Content.Catalog.E2ETests.GraphQL.Categories.Common;

using RepositoriesDto = Devflix.Content.Catalog.Domain.Repositories.DTOs;

using Devflix.Content.Catalog.Infra.Data.ES.Models;

namespace Devflix.Content.Catalog.E2ETests.GraphQL.Categories.SearchCategory;

public class SearchCategoryTestFixture : CategoryTestFixture
{
    public IList<CategoryModel> GetCategoryModelList(IEnumerable<string> categoryNames)
        => DataGenerator.GetCategoryModelList(categoryNames);

    public IList<CategoryModel> CloneCategoriesListOrdered(
        IList<CategoryModel> categoriesList,
        string orderBy,
        RepositoriesDto.SearchOrder direction)
        => DataGenerator.CloneCategoriesListOrdered(categoriesList, orderBy, direction);
}