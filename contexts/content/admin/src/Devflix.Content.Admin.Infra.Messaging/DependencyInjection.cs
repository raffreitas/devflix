using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Infra.Messaging.Configuration;
using Devflix.Content.Admin.Infra.Messaging.Producer;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using RabbitMQ.Client;

namespace Devflix.Content.Admin.Infra.Messaging;

public static class DependencyInjection
{
    public static IServiceCollection AddMessagingConfiguration(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddOptions<RabbitMqConfiguration>().BindConfiguration(RabbitMqConfiguration.ConfigurationSection);

        services.AddSingleton(sp =>
        {
            RabbitMqConfiguration config = sp.GetRequiredService<IOptions<RabbitMqConfiguration>>().Value;
            return new ConnectionFactory
            {
                HostName = config.Hostname,
                UserName = config.Username,
                Password = config.Password,
                Port = config.Port
            };
        });

        services.AddSingleton<ProducerConnection>(sp =>
        {
            var factory = sp.GetRequiredService<ConnectionFactory>();
            var connection = factory.CreateConnectionAsync("devflix-content-admin-producer").GetAwaiter().GetResult();
            return new ProducerConnection(connection);
        });

        services.AddSingleton<ConsumerConnection>(sp =>
        {
            var factory = sp.GetRequiredService<ConnectionFactory>();
            var connection = factory.CreateConnectionAsync("devflix-content-admin-consumer").GetAwaiter().GetResult();
            return new ConsumerConnection(connection);
        });

        services.AddSingleton(sp => new ChannelManager(sp.GetRequiredService<ProducerConnection>().Connection));

        services.AddTransient<IMessageProducer>(sp =>
        {
            var channelManager = sp.GetRequiredService<ChannelManager>();
            var config = sp.GetRequiredService<IOptions<RabbitMqConfiguration>>();
            return new RabbitMqProducer(channelManager, config);
        });

        return services;
    }

    public sealed record ProducerConnection(IConnection Connection) : IAsyncDisposable
    {
        public async ValueTask DisposeAsync()
        {
            if (Connection.IsOpen)
                await Connection.CloseAsync();

            await Connection.DisposeAsync();
        }
    }

    public sealed record ConsumerConnection(IConnection Connection) : IAsyncDisposable
    {
        public async ValueTask DisposeAsync()
        {
            if (Connection.IsOpen)
                await Connection.CloseAsync();

            await Connection.DisposeAsync();
        }
    }
}