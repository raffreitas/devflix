using System.Text.Json;

using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Infra.Messaging.Configuration;

using Microsoft.Extensions.Options;

using RabbitMQ.Client;

namespace Devflix.Content.Admin.Infra.Messaging.Producer;

public sealed class RabbitMqProducer(
    ChannelManager channelManager,
    IOptions<RabbitMqConfiguration> options
) : IMessageProducer
{
    private readonly string _exchange = options.Value.Exchange;

    public async Task SendMessageAsync<T>(T message, CancellationToken cancellationToken = default)
    {
        var routingKey = EventsMapping.GetRoutingKey<T>();
        var @event = JsonSerializer.SerializeToUtf8Bytes(message);
        var channel = await channelManager.GetChannelAsync(cancellationToken);

        using var publishLock = await channelManager.AcquirePublishLockAsync(cancellationToken);

        await channel.BasicPublishAsync(
            exchange: _exchange,
            routingKey: routingKey,
            mandatory: false,
            body: @event,
            cancellationToken: cancellationToken
        );
    }
}