using Azure.Storage.Blobs;

using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Infra.Storage.Services;
using Devflix.Content.Admin.Infra.Storage.Settings;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Devflix.Content.Admin.Infra.Storage;

public static class DependencyInjection
{
    public static IServiceCollection AddStorageConfiguration(this IServiceCollection services)
    {
        services.AddOptions<StorageSettings>().BindConfiguration(StorageSettings.ConfigurationSection);

        services.AddSingleton(sp =>
        {
            var settings = sp.GetRequiredService<IOptions<StorageSettings>>().Value;
            return new BlobServiceClient(settings.ConnectionString);
        });
        services.AddScoped<IStorageService, AzureBlobStorageService>();

        return services;
    }
}