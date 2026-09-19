using Devflix.Content.Catalog.Domain.Repositories.DTOs;

namespace Devflix.Content.Catalog.Domain.Repositories;

public interface IRepository<T> where T : class
{
    Task SaveAsync(T entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<SearchOutput<T>> SearchAsync(SearchInput input, CancellationToken cancellationToken = default);
}
