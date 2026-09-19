using System.Text.Json;

using Devflix.Content.Catalog.Infra.Messaging.JsonConverters;

namespace Devflix.Content.Catalog.Infra.Messaging.Configuration;

public static class SerializerConfiguration
{
    public static readonly JsonSerializerOptions JsonSerializerOptions = new(JsonSerializerDefaults.Web)
    {
        Converters = { new BoolConverter(), new DateTimeConverter() }
    };
}