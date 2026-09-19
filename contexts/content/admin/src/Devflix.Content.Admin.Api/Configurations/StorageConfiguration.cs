using Azure.Storage.Blobs;

using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Infra.Storage.Services;
using Devflix.Content.Admin.Infra.Storage.Settings;

namespace Devflix.Content.Admin.Api.Configurations;

public static class StorageConfiguration
{
    public static IServiceCollection AddStorage(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<StorageSettings>(configuration.GetSection(StorageSettings.ConfigurationSection));

        var settings = configuration.GetSection(StorageSettings.ConfigurationSection).Get<StorageSettings>() ??
                       throw new InvalidOperationException("Storage settings not found");

        services.AddSingleton(_ => new BlobServiceClient(settings.ConnectionString));
        services.AddScoped<IStorageService, AzureBlobStorageService>();

        return services;
    }
}