using Devflix.Content.Admin.Infra.Data.EF;

using Microsoft.EntityFrameworkCore;

using DomainEntity = Devflix.Content.Admin.Domain.Entities;

namespace Devflix.Content.Admin.EndToEndTests.Api.CastMembers.Common;

public class CastMemberPersistence(DevflixContentAdminDbContext context)
{
    public async Task InsertList(List<DomainEntity.CastMember> castMember)
    {
        await context.AddRangeAsync(castMember);
        await context.SaveChangesAsync();
    }

    public async Task<DomainEntity.CastMember?> GetById(Guid id)
        => await context.CastMembers.AsNoTracking()
            .FirstOrDefaultAsync(castMember => castMember.Id == id);
}