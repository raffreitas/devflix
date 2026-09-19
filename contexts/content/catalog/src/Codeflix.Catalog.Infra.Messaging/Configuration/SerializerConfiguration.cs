using System.Text.Json;

using Codeflix.Catalog.Infra.Messaging.JsonConverters;

namespace Codeflix.Catalog.Infra.Messaging.Configuration;

public static class SerializerConfiguration
{
    public static readonly JsonSerializerOptions JsonSerializerOptions = new(JsonSerializerDefaults.Web)
    {
        Converters = { new BoolConverter(), new DateTimeConverter() }
    };
}