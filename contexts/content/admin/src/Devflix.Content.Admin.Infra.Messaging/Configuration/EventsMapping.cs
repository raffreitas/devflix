using Devflix.Content.Admin.Domain.Events;

namespace Devflix.Content.Admin.Infra.Messaging.Configuration;

public static class EventsMapping
{
    private static readonly Dictionary<string, string> RoutingKeys = new()
    {
        { nameof(VideoUploadedEvent), "video.created" }
    };

    public static string GetRoutingKey<T>() => RoutingKeys[typeof(T).Name];
}