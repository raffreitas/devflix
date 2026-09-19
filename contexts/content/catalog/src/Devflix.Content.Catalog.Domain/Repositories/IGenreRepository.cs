using Devflix.Content.Catalog.Domain.Entities;

namespace Devflix.Content.Catalog.Domain.Repositories;

public interface IGenreRepository : IRepository<Genre>
{
    Task<IReadOnlyList<Genre>> GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default);
}