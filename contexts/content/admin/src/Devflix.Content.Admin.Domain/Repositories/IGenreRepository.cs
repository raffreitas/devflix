using Devflix.Content.Admin.Domain.Entities;
using Devflix.Content.Admin.Domain.SeedWork;
using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

namespace Devflix.Content.Admin.Domain.Repositories;

public interface IGenreRepository : IGenericRepository<Genre>, ISearchableRepository<Genre>
{
    public Task<IReadOnlyList<Guid>> GetIdsListByIds(
        List<Guid> ids,
        CancellationToken cancellationToken
    );

    public Task<IReadOnlyList<Genre>> GetListByIds(
        List<Guid> ids,
        CancellationToken cancellationToken
    );
}