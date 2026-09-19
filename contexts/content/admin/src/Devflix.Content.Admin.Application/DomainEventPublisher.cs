using Devflix.Content.Admin.Domain.SeedWork;

using Microsoft.Extensions.DependencyInjection;

namespace Devflix.Content.Admin.Application;

public sealed class DomainEventPublisher(IServiceProvider serviceProvider) : IDomainEventPublisher
{
    public async Task PublishAsync<TDomainEvent>(TDomainEvent @event, CancellationToken cancellationToken = default)
        where TDomainEvent : DomainEvent
    {
        var handlers = serviceProvider.GetServices<IDomainEventHandler<TDomainEvent>>().ToList();
        if (handlers.Count == 0) return;
        var tasks = handlers.Select(handler => handler.HandleAsync(@event, cancellationToken));
        await Task.WhenAll(tasks);
    }
}