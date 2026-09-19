using Devflix.Content.Admin.Application;
using Devflix.Content.Admin.Application.EventHandlers;
using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Application.UseCases.Categories.CreateCategory;
using Devflix.Content.Admin.Domain.Events;
using Devflix.Content.Admin.Domain.Repositories;
using Devflix.Content.Admin.Domain.SeedWork;
using Devflix.Content.Admin.Infra.Data.EF;
using Devflix.Content.Admin.Infra.Data.EF.Repositories;
using Devflix.Content.Admin.Infra.Messaging.Configuration;
using Devflix.Content.Admin.Infra.Messaging.Producer;

using Microsoft.Extensions.Options;

using RabbitMQ.Client;

namespace Devflix.Content.Admin.Api.Configurations;

public static class UseCasesConfiguration
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateCategoryUseCase>());
        services.AddRepositories();
        services.AddDomainEvents();
        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IDomainEventPublisher, DomainEventPublisher>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IGenreRepository, GenreRepository>();
        services.AddScoped<ICastMemberRepository, CastMemberRepository>();
        services.AddScoped<IVideoRepository, VideoRepository>();
        return services;
    }

    private static IServiceCollection AddDomainEvents(this IServiceCollection services)
    {
        services.AddTransient<IDomainEventPublisher, DomainEventPublisher>();
        services.AddTransient<IDomainEventHandler<VideoUploadedEvent>, SentToEncoderEventHandler>();
        return services;
    }
}