namespace Devflix.Content.Admin.Application.Interfaces;

public interface IUnitOfWork
{
    public Task Commit(CancellationToken cancellationToken = default);
    public Task Rollback(CancellationToken cancellationToken = default);
}