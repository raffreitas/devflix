using Devflix.Content.Admin.Domain.Entities;
using Devflix.Content.Admin.Infra.Data.EF;

using Microsoft.EntityFrameworkCore;

namespace Devflix.Content.Admin.EndToEndTests.Api.Categories.Common;
public class CategoryPersistence(DevflixContentAdminDbContext dbContext)
{
    public async Task<Category?> GetById(Guid id)
        => await dbContext.Categories
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

    public async Task InsertList(List<Category> categories)
    {
        await dbContext.Categories.AddRangeAsync(categories);
        await dbContext.SaveChangesAsync();
    }
}
