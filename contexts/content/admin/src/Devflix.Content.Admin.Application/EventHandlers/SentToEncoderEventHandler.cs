using Devflix.Content.Admin.Application.Interfaces;

using Devflix.Content.Admin.Domain.Events;
using Devflix.Content.Admin.Domain.SeedWork;

namespace Devflix.Content.Admin.Application.EventHandlers;

public sealed class SentToEncoderEventHandler(IMessageProducer messageProducer)
    : IDomainEventHandler<VideoUploadedEvent>
{
    public async Task HandleAsync(VideoUploadedEvent @event, CancellationToken cancellationToken = default)
        => await messageProducer.SendMessageAsync(@event, cancellationToken);
}