using Devflix.Content.Admin.Domain.Entities;
using Devflix.Content.Admin.Domain.SeedWork;
using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

namespace Devflix.Content.Admin.Domain.Repositories;

public interface ICastMemberRepository : IGenericRepository<CastMember>, ISearchableRepository<CastMember>
{
    public Task<IReadOnlyList<Guid>> GetIdsListByIds(
        List<Guid> ids,
        CancellationToken cancellationToken
    );
}