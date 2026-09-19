using Devflix.Content.Admin.Infra.Messaging;
using Devflix.Content.Admin.Infra.Messaging.Configuration;
using Devflix.Content.Admin.Infra.Messaging.Consumers;

using Microsoft.Extensions.Options;

namespace Devflix.Content.Admin.Api.Configurations;

public static class BackgroundServiceConfiguration
{
    public static IServiceCollection AddBackgroundServiceConfiguration(this IServiceCollection services)
    {
        services.AddHostedService(sp =>
        {
            var cfg = sp.GetRequiredService<IOptions<RabbitMqConfiguration>>();
            var connection = sp.GetRequiredService<DependencyInjection.ConsumerConnection>();
            var logger = sp.GetRequiredService<ILogger<VideoEncodedEventConsumer>>();
            var channel = connection.Connection.CreateChannelAsync().GetAwaiter().GetResult();
            return new VideoEncodedEventConsumer(sp, logger, cfg, channel);
        });

        return services;
    }
}