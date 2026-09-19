using Devflix.Content.Admin.Infra.Data.EF;
using Devflix.Content.Admin.Infra.Data.EF.Models;

using Microsoft.EntityFrameworkCore;

using DomainEntity = Devflix.Content.Admin.Domain.Entities;

namespace Devflix.Content.Admin.EndToEndTests.Api.Genres.Common;

public class GenrePersistence(DevflixContentAdminDbContext context)
{
    public async Task InsertList(List<DomainEntity.Genre> genres)
    {
        await context.AddRangeAsync(genres);
        await context.SaveChangesAsync();
    }

    public async Task InsertGenresCategoriesRelationsList(List<GenresCategories> relations)
    {
        await context.AddRangeAsync(relations);
        await context.SaveChangesAsync();
    }

    public async Task<DomainEntity.Genre?> GetById(Guid id)
        => await context.Genres.AsNoTracking()
            .FirstOrDefaultAsync(genre => genre.Id == id);

    internal async Task<List<GenresCategories>> GetGenresCategoriesRelationsByGenreId(Guid id)
        => await context.GenresCategories.AsNoTracking()
            .Where(relation => relation.GenreId == id)
            .ToListAsync();
}