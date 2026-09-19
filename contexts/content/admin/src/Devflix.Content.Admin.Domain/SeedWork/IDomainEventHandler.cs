namespace Devflix.Content.Admin.Domain.SeedWork;

public interface IDomainEventHandler<in TDomainEvent> where TDomainEvent : DomainEvent
{
    Task HandleAsync(TDomainEvent @event, CancellationToken cancellationToken = default);
}